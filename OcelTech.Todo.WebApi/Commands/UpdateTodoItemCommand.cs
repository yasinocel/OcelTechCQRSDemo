using MediatR;
using OcelTech.Todo.WebApi.Dto.Request;
using OcelTech.Todo.WebApi.Dto.Response;

namespace OcelTech.Todo.WebApi.Commands
{
    public class UpdateTodoItemCommand : IRequest<UpdateTodoItemResponse>
    {
        public UpdateTodoItemRequest UpdateTodoItemRequest { get; set; }
        public UpdateTodoItemCommand(UpdateTodoItemRequest updateTodoItemRequest)
        {
            UpdateTodoItemRequest = updateTodoItemRequest;
        }
    }
}
