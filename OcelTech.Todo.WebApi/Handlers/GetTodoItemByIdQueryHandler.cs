using AutoMapper;
using MediatR;
using OcelTech.Todo.WebApi.Dto.Response;
using OcelTech.Todo.WebApi.Queries;
using OcelTech.Todo.WebApi.Repositories;

namespace OcelTech.Todo.WebApi.Handlers
{
    public class GetTodoItemByIdQueryHandler : IRequestHandler<GetTodoItemByIdQuery, GetTodoItemByIdQueryResponse>
    {

        private readonly ITodoRepository _repository;
        private readonly IMapper _mapper;

        public GetTodoItemByIdQueryHandler(ITodoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }

        public async Task<GetTodoItemByIdQueryResponse> Handle(GetTodoItemByIdQuery request, CancellationToken cancellationToken)
        {
            var todoItem = await _repository.GetTodoItemById(request.Id);
            if (todoItem == null)
            {
                return null!;
            }

            return _mapper.Map<GetTodoItemByIdQueryResponse>(todoItem);
        }
    }
}
