using Gerenciador.Communication.Response;


namespace Gerenciador.Application.UseCase.Task.GetAll
{
    public class GetAllUserCase
    {
        public  ResponseAllTaskJson Executar()
        {
            return new ResponseAllTaskJson
            {
                ShortTasks = new List<ResponseShortTaskJson>()
                {
                    new ResponseShortTaskJson
                    {
                        Id = 1,
                        Name = "Read",
                        Status = Communication.Enum.Status.InProgress,
                    }
                }

            };
        }
    }
}
