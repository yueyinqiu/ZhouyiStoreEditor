using Blazor.FileUtilities;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ZhouyiStoreEditor.Serialization;
using ZhouyiStoreEditor.Services;

namespace ZhouyiStoreEditor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            _ = builder.Services.AddBlazoredLocalStorage((options) => {
                // options.JsonSerializerOptions.AddContext<ZhouyiStoreSerializerContext>();
            });

            _ = builder.Services.AddBlazorFileUtilities();

            _ = builder.Services.AddScoped<StoreManager>();

            await builder.Build().RunAsync();
        }
    }
}