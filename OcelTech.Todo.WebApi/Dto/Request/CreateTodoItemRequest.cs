namespace OcelTech.Todo.WebApi.Dto.Request
{
    public class CreateTodoItemRequest
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
