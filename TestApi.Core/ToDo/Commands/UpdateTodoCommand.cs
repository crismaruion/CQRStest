using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TestApi.Core.Domain;
using TestApi.Core.DtoModels;

namespace TestApi.Core.ToDo.Commands
{
    public class UpdateTodoCommand : IRequest<ToDoDto>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTimeOffset? Deadline { get; set; }
    }
}
