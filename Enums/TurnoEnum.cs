using System.Text.Json.Serialization;

namespace ISI_WebAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TurnoEnum
    {
        Manhã,
        Normal,
        Noite
    }
}
