using AutoMapper;
using MediatR;
using OcelTech.Todo.WebApi.Commands;
using OcelTech.Todo.WebApi.Repositories;

namespace OcelTech.Todo.WebApi.Handlers
{
    public class DeleteTodoItemCommandHandler : IRequestHandler<DeleteTodoItemCommand, Unit>
    {


        private readonly ITodoRepository _repository;

        public DeleteTodoItemCommandHandler(ITodoRepository repository)
        {
            _repository = repository;

        }

        public async Task<Unit> Handle(DeleteTodoItemCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteTodoItem(request.Id);
            return Unit.Value;
        }
    }
}
