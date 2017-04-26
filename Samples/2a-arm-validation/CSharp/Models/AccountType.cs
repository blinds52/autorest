// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Storage.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AccountType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountType
    {
        [EnumMember(Value = "Standard_LRS")]
        StandardLRS,
        [EnumMember(Value = "Standard_ZRS")]
        StandardZRS,
        [EnumMember(Value = "Standard_GRS")]
        StandardGRS,
        [EnumMember(Value = "Standard_RAGRS")]
        StandardRAGRS,
        [EnumMember(Value = "Premium_LRS")]
        PremiumLRS
    }
}
