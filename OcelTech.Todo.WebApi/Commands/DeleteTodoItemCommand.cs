using MediatR;
using OcelTech.Todo.WebApi.Dto.Request;

namespace OcelTech.Todo.WebApi.Commands
{
    public class DeleteTodoItemCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteTodoItemCommand(int id)
        {
            Id = id;
        }
    }
}
