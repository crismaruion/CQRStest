using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestApi.Core.Domain;
using TestApi.Core.DtoModels;
using TestApi.Core.Interfaces;
using TestApi.Core.ToDo.Commands;

namespace TestApi.Core.ToDo.CommandsHandlers
{
    public class CreateTodoHandler : IRequestHandler<CreateTodoCommand, ToDoDto>
    {
        private readonly IRepository<TodoEntity> _todoRepository;
        private readonly IMapper _mapper;
        public CreateTodoHandler(IRepository<TodoEntity> todoRepository, IMapper mapper)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
        }

        public async Task<ToDoDto> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
        {
            var newEntity = new TodoEntity
            {
                Deadline = request.Deadline,
                Description = request.Description
            };

            await _todoRepository.AddAsync(newEntity);
            _todoRepository.Save();
            var result = _mapper.Map<ToDoDto>(newEntity);
            return result;
            
        }
    }
}
