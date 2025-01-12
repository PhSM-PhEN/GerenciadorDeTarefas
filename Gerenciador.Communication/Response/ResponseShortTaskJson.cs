using Gerenciador.Communication.Enum;

namespace Gerenciador.Communication.Response
{
    public class ResponseShortTaskJson
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public Status Status { get; set; }
    }
}
