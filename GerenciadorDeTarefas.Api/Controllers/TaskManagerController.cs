
using Gerenciador.Application.UseCase.Task.Delete;
using Gerenciador.Application.UseCase.Task.GetAll;
using Gerenciador.Application.UseCase.Task.GetById;
using Gerenciador.Application.UseCase.Task.Register;
using Gerenciador.Application.UseCase.Task.Update;
using Gerenciador.Communication.Request;
using Gerenciador.Communication.Response;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskManagerController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] RequestRegisterTaskJson request)
        {
            var useCase = new RegisterTaskUseCase().Execute(request);
            var response = useCase;


            return Created(string.Empty, response);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestRegisterTaskJson request)
        {
            var useCase = new UpdateTaskUseCase();
            useCase.Executar(id, request);
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var useCase = new GetAllUserCase();
            var response = useCase.Executar();
            if (response.ShortTasks.Any())
            {
                return Ok(response);
            }
            return NoContent();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ResponseTaskdJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
        public IActionResult GetId(int id)
        {
            var useCase = new GetByIdUseCase();
            var response = useCase.Executar(id);
            if (response != null)
            {
                return Ok(response);
            }
            return NotFound(new ResponseErrosJson { Errors = new List<string> { "Task not found" } });
        }
        [HttpDelete]
        [ProducesResponseType(typeof(ResponseTaskdJson), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete([FromRoute]int id)
        {
            var useCase = new DeleteUseCase();
            useCase.Executar(id);
            return NoContent();
        }
    }
}