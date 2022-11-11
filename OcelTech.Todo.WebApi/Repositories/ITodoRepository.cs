using OcelTech.Todo.WebApi.Models;

namespace OcelTech.Todo.WebApi.Repositories
{
    public interface ITodoRepository
    {
        Task<IEnumerable<TodoItem>> GetTodoItems();
        Task<TodoItem> GetTodoItemById(int id);
        Task<TodoItem> CreateTodoItem(TodoItem todoItem);
        Task<TodoItem> UpdateTodoItem( TodoItem todoItem);
        Task DeleteTodoItem(int id);
    }
}

