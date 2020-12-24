using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TestApi.Core.DtoModels;

namespace TestApi.Core.ToDo.Queries
{
    public class GetTodoByIdQuery : IRequest<ToDoDto>
    {
        public int Id { get; set; }
        public GetTodoByIdQuery(int id)
        {
            Id = id;
        }
    }
}
