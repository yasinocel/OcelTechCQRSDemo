using Microsoft.EntityFrameworkCore;
using OcelTech.Todo.WebApi.Models;

namespace OcelTech.Todo.WebApi.Data
{
    public class TodoContext : DbContext
    {

        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }


        public DbSet<TodoItem> TodoItems { get; set; } = null!;

    }
}
