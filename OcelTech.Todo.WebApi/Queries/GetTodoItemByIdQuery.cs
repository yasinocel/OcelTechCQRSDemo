using MediatR;
using OcelTech.Todo.WebApi.Dto.Response;

namespace OcelTech.Todo.WebApi.Queries
{
    public class GetTodoItemByIdQuery : IRequest<GetTodoItemByIdQueryResponse>
    {
        public int Id { get; set; }

        public GetTodoItemByIdQuery(int id)
        {
            Id = id;
        }
    }
}
