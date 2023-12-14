namespace ISI_WebAPI.Models
{
    public class ServiceResponse<T> // pode receber dados genéricos, de outros Models
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Sucesso { get; set; } = true;
    }
}
