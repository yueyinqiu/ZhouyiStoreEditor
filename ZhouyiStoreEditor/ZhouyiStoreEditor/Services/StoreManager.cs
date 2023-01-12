using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using System.Text.Json;
using YiJingFramework.Annotating.Zhouyi;
using Blazored.LocalStorage;
using Microsoft.JSInterop;

namespace ZhouyiStoreEditor.Services
{
    public class StoreManager : IDisposable
    {
        readonly ILocalStorageService localStorage;
        readonly System.Timers.Timer autoSaveTimer;

        public ZhouyiStore Store { get; private set; }

        public StoreManager(ILocalStorageService localStorage)
        {
            this.localStorage = localStorage;

            autoSaveTimer = new(new TimeSpan(0, 0, 30));
            autoSaveTimer.Elapsed += async (_, _) => {
                var s = await SaveToLocalStorage();
                await OnAutoSavedToLocalStorage.InvokeAsync(s);
            };
        }

        public EventCallback<bool> OnAutoSavedToLocalStorage { get; set; }

        public async Task<bool> SaveToLocalStorage()
        {
            try
            {
                if (this.Store is null)
                    await localStorage.RemoveItemAsync("store");
                else
                    await localStorage.SetItemAsync("store", this.Store);
                return true;
            }
            catch (JSException)
            {
                return false;
            }
        }

        public async Task<bool> TryLoadFromLocalStorage()
        {
            try
            {
                if (await localStorage.ContainKeyAsync("store"))
                {
                    var store = await localStorage.GetItemAsync<ZhouyiStore>("store");
                    autoSaveTimer.Stop();
                    this.Store = store;
                    autoSaveTimer.Start();
                    return true;
                }
                return false;
            }
            catch
            {
                return true;
            }
        }

        public void CloseStore()
        {
            autoSaveTimer.Stop();
            this.Store = null;
        }

        public void NewStore()
        {
            autoSaveTimer.Stop();
            this.Store = new ZhouyiStore(null);
            autoSaveTimer.Start();
        }

        public async Task<bool> OpenStore(IBrowserFile file)
        {
            try
            {
                using var stream = file.OpenReadStream();
                var store = await JsonSerializer.DeserializeAsync<ZhouyiStore>(stream);
                autoSaveTimer.Stop();
                this.Store = store ?? new ZhouyiStore(null);
                autoSaveTimer.Start();
                return true;
            }
            catch (IOException)
            {
                return false;
            }
            catch (JsonException)
            {
                return false;
            }
        }

        public async Task<Stream> ExportStoreAsStream()
        {
            var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, Store);
            stream.Position = 0;
            return stream;
        }

        public void Dispose()
        {
            autoSaveTimer.Dispose();
        }
    }
}
