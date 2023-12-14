using System.Text.Json.Serialization;

namespace ISI_WebAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum
    {
        RH,
        IT,
        Comercial,
        Design,
        Acessórios
    }
}
