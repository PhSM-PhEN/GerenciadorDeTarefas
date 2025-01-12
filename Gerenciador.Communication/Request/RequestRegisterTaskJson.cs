﻿using Gerenciador.Communication.Enum;

namespace Gerenciador.Communication.Request
{
    public class RequestRegisterTaskJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description {  get; set; } = string.Empty;
        public Prioridade Prioridade { get; set; } 
        public Status Status { get; set; } 

    }
}
