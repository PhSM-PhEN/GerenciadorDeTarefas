using Gerenciador.Communication.Request;
using Gerenciador.Communication.Response;
namespace Gerenciador.Application.UseCase.Task.Register
{
    public class RegisterTaskUseCase
    {
        public ResponseRegisterTaskJson Execute(RequestRegisterTaskJson request)
        {
            return new ResponseRegisterTaskJson
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                Prioridade = request.Prioridade,
                Status = request.Status,
            };
        }
    }
}
