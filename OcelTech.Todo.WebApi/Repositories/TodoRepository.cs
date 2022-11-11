using Microsoft.EntityFrameworkCore;
using OcelTech.Todo.WebApi.Data;
using OcelTech.Todo.WebApi.Models;

namespace OcelTech.Todo.WebApi.Repositories
{
    public class TodoRepository : ITodoRepository
    {

        private readonly TodoContext _context;

        public TodoRepository(TodoContext context)
        {
            _context = context;
        }

        public async Task<TodoItem> CreateTodoItem(TodoItem todoItem)
        {

            _context.Add(todoItem);
            await _context.SaveChangesAsync();

            return todoItem;

        }

        public async Task<TodoItem> UpdateTodoItem(TodoItem todoItem)
        {
            if (todoItem == null)
            {
                return null!;
            }

            var persistItem = await _context.FindAsync<TodoItem>(todoItem.Id);
            if (persistItem == null)
            {
                return null!;
            }

            _context.Entry(persistItem).CurrentValues.SetValues(todoItem);
            await _context.SaveChangesAsync();

            return persistItem!;

        }

        public async Task DeleteTodoItem(int id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return;
            }
            _context.TodoItems.Remove(todoItem);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TodoItem>> GetTodoItems()
        {
            return await _context.TodoItems.ToListAsync();
        }

        public async Task<TodoItem> GetTodoItemById(int id)
        {
            var todoItem = await _context.FindAsync<TodoItem>(id);
            if (todoItem == null)
            {
                return null!;
            }
            return todoItem;
        }
    }
}
