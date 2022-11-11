using MediatR;
using Microsoft.EntityFrameworkCore;
using OcelTech.Todo.WebApi.Data;
using OcelTech.Todo.WebApi.Mapping;
using OcelTech.Todo.WebApi.Repositories;
using System.Reflection;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var services = builder.Services;

services.AddControllers();

services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));

services.AddMediatR(Assembly.GetExecutingAssembly());

services.AddScoped<ITodoRepository, TodoRepository>();

services.AddAutoMapper(typeof(TodoProfile));
 

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
