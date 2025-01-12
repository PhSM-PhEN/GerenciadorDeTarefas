using Gerenciador.Communication.Response;

namespace Gerenciador.Application.UseCase.Task.GetById
{
    public class GetByIdUseCase
    {
        public ResponseTaskdJson Executar(int id)
        {
            return new ResponseTaskdJson
            {
                Id = id,
                Name = "Fazer Cafe",
                Description = "Logica do Cafe",
                prioridade = Communication.Enum.Prioridade.Alta,
                status = Communication.Enum.Status.InProgress,

            };
        }
    }
}
