// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bonsai.SimulatorApi.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UnregisterReason.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UnregisterReason
    {
        [EnumMember(Value = "Unspecified")]
        Unspecified,
        [EnumMember(Value = "Finished")]
        Finished,
        [EnumMember(Value = "Error")]
        Error,
        [EnumMember(Value = "NotFound")]
        NotFound
    }
    internal static class UnregisterReasonEnumExtension
    {
        internal static string ToSerializedValue(this UnregisterReason? value)
        {
            return value == null ? null : ((UnregisterReason)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this UnregisterReason value)
        {
            switch( value )
            {
                case UnregisterReason.Unspecified:
                    return "Unspecified";
                case UnregisterReason.Finished:
                    return "Finished";
                case UnregisterReason.Error:
                    return "Error";
                case UnregisterReason.NotFound:
                    return "NotFound";
            }
            return null;
        }

        internal static UnregisterReason? ParseUnregisterReason(this string value)
        {
            switch( value )
            {
                case "Unspecified":
                    return UnregisterReason.Unspecified;
                case "Finished":
                    return UnregisterReason.Finished;
                case "Error":
                    return UnregisterReason.Error;
                case "NotFound":
                    return UnregisterReason.NotFound;
            }
            return null;
        }
    }
}