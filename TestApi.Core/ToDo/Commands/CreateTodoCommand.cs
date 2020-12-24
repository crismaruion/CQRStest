using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TestApi.Core.DtoModels;

namespace TestApi.Core.ToDo.Commands
{
    public class CreateTodoCommand : IRequest<ToDoDto>
    {
        public string Description { get; set; }
        public DateTimeOffset Deadline { get; set; }
    }
}
