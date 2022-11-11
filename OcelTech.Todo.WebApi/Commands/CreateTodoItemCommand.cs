using MediatR;
using OcelTech.Todo.WebApi.Dto.Request;
using OcelTech.Todo.WebApi.Dto.Response;

namespace OcelTech.Todo.WebApi.Commands
{
    public class CreateTodoItemCommand : IRequest<CreateTodoItemResponse>
    {
        public CreateTodoItemRequest CreateTodoItemRequest { get; set; }

        public CreateTodoItemCommand(CreateTodoItemRequest createTodoItemRequest)
        {
            CreateTodoItemRequest = createTodoItemRequest;
        }
    }
}
