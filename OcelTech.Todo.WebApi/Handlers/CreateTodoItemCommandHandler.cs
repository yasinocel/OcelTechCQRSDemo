using AutoMapper;
using MediatR;
using OcelTech.Todo.WebApi.Commands;
using OcelTech.Todo.WebApi.Dto.Request;
using OcelTech.Todo.WebApi.Dto.Response;
using OcelTech.Todo.WebApi.Models;
using OcelTech.Todo.WebApi.Repositories;

namespace OcelTech.Todo.WebApi.Handlers
{
    public class CreateTodoItemCommandHandler : IRequestHandler<CreateTodoItemCommand, CreateTodoItemResponse>
    {

        private readonly ITodoRepository _repository;
        private readonly IMapper _mapper;

        public CreateTodoItemCommandHandler(ITodoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CreateTodoItemResponse> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
        {
            var todoItem = _mapper.Map<TodoItem>(request.CreateTodoItemRequest);
            var response = await _repository.CreateTodoItem(todoItem);
            return _mapper.Map<CreateTodoItemResponse>(response);
        }
    }
}
