using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestApi.Core.Domain;
using TestApi.Core.Interfaces;
using TestApi.Core.ToDo.Commands;

namespace TestApi.Core.ToDo.CommandsHandlers
{
    public class DeleteTodoHandler : IRequestHandler<DeleteToDoCommand>
    {
        private readonly IRepository<TodoEntity> _todoRepository;

        public DeleteTodoHandler(IRepository<TodoEntity> todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<Unit> Handle(DeleteToDoCommand request, CancellationToken cancellationToken)
        {
            var todo = await _todoRepository.GetByIdAsync(request.TodoId);
            if (todo != null)
            {
                _todoRepository.Delete(todo);
                _todoRepository.Save();
            }
            return await Unit.Task;
        }
    }
}
