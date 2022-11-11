using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using OcelTech.Todo.WebApi.Commands;
using OcelTech.Todo.WebApi.Dto.Request;
using OcelTech.Todo.WebApi.Dto.Response;
using OcelTech.Todo.WebApi.Models;
using OcelTech.Todo.WebApi.Queries;
using OcelTech.Todo.WebApi.Repositories;

namespace OcelTech.Todo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : BaseController
    {

        private readonly IMediator _mediator;
        private readonly ITodoRepository _repository;

        public TodoController(IMediator mediator, ITodoRepository repository)
        {
            _mediator = mediator;
            _repository = repository;
        }

        [HttpGet()]
        public async Task<IActionResult> GeTodoItems()
        {

            var result = await _mediator.Send(new GetTodoItemsQuery());

            if (result == null)
            {
                return NoContent();
            }

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GeTodoItem(int id)
        {

            var result = await _mediator.Send(new GetTodoItemByIdQuery(id));
            if (result == null)
            {
                return NoContent();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostTodoItem([FromBody] CreateTodoItemRequest todoItemRequest)
        {
            if (!ModelState.IsValid)
            {
                return ValidationFailed();
            }

            var result = await _mediator.Send(new CreateTodoItemCommand(todoItemRequest));

            return CreatedAtAction("GeTodoItem", new { id = result.Id }, result);
        }


        [HttpPut()]
        public async Task<IActionResult> PutTodoItem([FromBody] UpdateTodoItemRequest todoItemRequest)
        {
            var result = await _mediator.Send(new UpdateTodoItemCommand(todoItemRequest));
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(int id)
        {
            await _mediator.Send(new DeleteTodoItemCommand(id));
            return Ok();
        }
    }


}
