using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TestApi.Core.Domain;
using TestApi.Core.DtoModels;
using TestApi.Core.Interfaces;
using TestApi.Core.ToDo.Commands;

namespace TestApi.Core.ToDo.CommandsHandlers
{
    public class UpdateTodoHandler : IRequestHandler<UpdateTodoCommand, ToDoDto>
    {
        private readonly IRepository<TodoEntity> _todoRepository;
        private readonly IMapper _mapper;

        public UpdateTodoHandler(IRepository<TodoEntity> todoRepository, IMapper mapper)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
        }
        public async Task<ToDoDto> Handle(UpdateTodoCommand request, CancellationToken cancellationToken)
        {
            var todo = await _todoRepository.GetByIdAsync(request.Id);

            if(todo != null)
            {
                if (!string.IsNullOrWhiteSpace(request.Description))
                {
                    todo.Description = request.Description;
                }

                if(request.Deadline != null)
                {
                    todo.Deadline = request.Deadline;
                }
            }
            _todoRepository.Save();
            return _mapper.Map<ToDoDto>(todo);
        }
    }
}
