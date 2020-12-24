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
using TestApi.Core.ToDo.Queries;

namespace TestApi.Core.ToDo.QueriesHandlers
{
    public class GetTodoByIdHandler : IRequestHandler<GetTodoByIdQuery, ToDoDto>
    {
        private readonly IRepository<TodoEntity> _todoRepository;
        private readonly IMapper _mapper;

        public GetTodoByIdHandler(IRepository<TodoEntity> todoRepository, IMapper mapper)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
        }

        public async Task<ToDoDto> Handle(GetTodoByIdQuery request, CancellationToken cancellationToken)
        {
            var todo = await _todoRepository.GetByIdAsync(request.Id);
            var result = _mapper.Map<ToDoDto>(todo);
            return result;
        }
    }
}
