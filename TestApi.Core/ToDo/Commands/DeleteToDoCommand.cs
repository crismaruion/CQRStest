using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestApi.Core.ToDo.Commands
{
    public class DeleteToDoCommand : IRequest
    {
        public int TodoId { get; set; }
    }
}
