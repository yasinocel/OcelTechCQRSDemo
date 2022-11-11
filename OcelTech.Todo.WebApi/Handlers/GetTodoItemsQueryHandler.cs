using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using OcelTech.Todo.WebApi.Dto.Response;
using OcelTech.Todo.WebApi.Queries;
using OcelTech.Todo.WebApi.Repositories;

namespace OcelTech.Todo.WebApi.Handlers
{
    public class GetTodoItemsQueryHandler : IRequestHandler<GetTodoItemsQuery, IEnumerable<GetTodoItemsQueryResponse>>
    {

        private readonly ITodoRepository _repository;
        private readonly IMapper _mapper;

        public GetTodoItemsQueryHandler(ITodoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }

        public async Task<IEnumerable<GetTodoItemsQueryResponse>> Handle(GetTodoItemsQuery request, CancellationToken cancellationToken)
        {
            var todoItems = await _repository.GetTodoItems();
            if (todoItems.Count() == 0)
            {
                return null!;
            }
            return _mapper.Map<IEnumerable<GetTodoItemsQueryResponse>>(todoItems);
        }
    }
}
