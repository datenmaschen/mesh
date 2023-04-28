using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Datamesh.Models.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataproductStatus
    {
        New,
        Requested,
        AdGroupProvisioning,
        Deploying,
        Active,
        Depreciated
    }
}