using System.Text.Json.Serialization;
using YiJingFramework.Annotating.Zhouyi;

namespace ZhouyiStoreEditor.Serialization
{
    [JsonSerializable(typeof(ZhouyiStore))]
    internal sealed partial class ZhouyiStoreSerializerContext : JsonSerializerContext
    {
    }
}
