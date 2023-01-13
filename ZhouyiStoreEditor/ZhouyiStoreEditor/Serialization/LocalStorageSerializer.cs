using Blazored.LocalStorage.Serialization;
using System.Text.Json;
using YiJingFramework.Annotating.Zhouyi;

namespace ZhouyiStoreEditor.Serialization
{
    public sealed class LocalStorageSerializer : IJsonSerializer
    {
        public T Deserialize<T>(string text)
        {
            if (typeof(T) == typeof(ZhouyiStore))
            {
                var result = JsonSerializer.Deserialize(
                     text, ZhouyiStoreSerializerContext.Default.ZhouyiStore);
                return (T)(object)result;
            }
            throw new NotSupportedException("LocalStorageSerializer only supports ZhouyiStore.");
        }

        public string Serialize<T>(T obj)
        {
            if (obj is ZhouyiStore store)
            {
                return JsonSerializer.Serialize(
                    store, ZhouyiStoreSerializerContext.Default.ZhouyiStore);
            }
            throw new NotSupportedException("LocalStorageSerializer only supports ZhouyiStore.");
        }
    }
}
