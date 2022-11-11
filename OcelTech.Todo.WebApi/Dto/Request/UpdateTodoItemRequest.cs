using OcelTech.Todo.WebApi.Models;

namespace OcelTech.Todo.WebApi.Dto.Request
{
    public class UpdateTodoItemRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
