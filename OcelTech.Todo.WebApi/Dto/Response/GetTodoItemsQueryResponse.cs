namespace OcelTech.Todo.WebApi.Dto.Response
{
    public class GetTodoItemsQueryResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
