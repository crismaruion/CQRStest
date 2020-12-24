using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TestApi.Core.DtoModels;

namespace TestApi.Core.Queries
{
    public class GetAllTodosQuery : IRequest<List<ToDoDto>>
    {
    }
}
