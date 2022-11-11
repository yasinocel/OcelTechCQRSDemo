namespace OcelTech.Todo.WebApi.Dto.Response
{
    public class UpdateTodoItemResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
