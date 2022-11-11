using AutoMapper;
using OcelTech.Todo.WebApi.Dto.Request;
using OcelTech.Todo.WebApi.Dto.Response;
using OcelTech.Todo.WebApi.Models;


namespace OcelTech.Todo.WebApi.Mapping
{
    public class TodoProfile : Profile
    {

        public TodoProfile()
        {
            CreateMap<TodoItem, GetTodoItemsQueryResponse>();
            CreateMap<TodoItem, GetTodoItemByIdQueryResponse>();

            CreateMap<CreateTodoItemRequest,TodoItem>();
            CreateMap<TodoItem, CreateTodoItemResponse>();

            CreateMap<UpdateTodoItemRequest, TodoItem>();
            CreateMap<TodoItem, UpdateTodoItemResponse>();


        }
    }
}
