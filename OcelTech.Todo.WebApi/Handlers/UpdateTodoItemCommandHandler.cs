using AutoMapper;
using MediatR;
using NuGet.Protocol.Plugins;
using OcelTech.Todo.WebApi.Commands;
using OcelTech.Todo.WebApi.Dto.Response;
using OcelTech.Todo.WebApi.Models;
using OcelTech.Todo.WebApi.Repositories;

namespace OcelTech.Todo.WebApi.Handlers
{
    public class UpdateTodoItemCommandHandler : IRequestHandler<UpdateTodoItemCommand, UpdateTodoItemResponse>
    {

        private readonly ITodoRepository _repository;
        private readonly IMapper _mapper;

        public UpdateTodoItemCommandHandler(ITodoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<UpdateTodoItemResponse> Handle(UpdateTodoItemCommand request, CancellationToken cancellationToken)
        {
            var todoItem = _mapper.Map<TodoItem>(request.UpdateTodoItemRequest);
            var response = await _repository.UpdateTodoItem(todoItem);
            return _mapper.Map<UpdateTodoItemResponse>(response);
        }
    }
}
