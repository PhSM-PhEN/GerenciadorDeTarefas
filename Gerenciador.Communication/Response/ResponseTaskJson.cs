using Gerenciador.Communication.Enum;

namespace Gerenciador.Communication.Response
{
    public class ResponseTaskdJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Prioridade prioridade { get; set; }
        public Status status { get; set; }
    }
}
