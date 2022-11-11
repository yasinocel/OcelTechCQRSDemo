using MediatR;
using OcelTech.Todo.WebApi.Dto.Response;

namespace OcelTech.Todo.WebApi.Queries
{
    public class GetTodoItemsQuery:IRequest<IEnumerable<GetTodoItemsQueryResponse>>
    {
    }
}
