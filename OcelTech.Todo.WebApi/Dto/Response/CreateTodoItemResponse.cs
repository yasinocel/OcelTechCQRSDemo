namespace OcelTech.Todo.WebApi.Dto.Response
{
    public class CreateTodoItemResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
