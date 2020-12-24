using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestApi.Core.Domain;
using TestApi.Core.DtoModels;
using TestApi.Core.Interfaces;
using TestApi.Core.Queries;
using System.Linq;
using AutoMapper;

namespace TestApi.Core.ToDo.QueriesHandlers
{
    public class GetAllTodosHandler : IRequestHandler<GetAllTodosQuery, List<ToDoDto>>
    {
        private readonly IRepository<TodoEntity> _todoRepository;
        private readonly IMapper _mapper;
        
        public GetAllTodosHandler(IRepository<TodoEntity> todoRepository, IMapper mapper)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
        }
        public async Task<List<ToDoDto>> Handle(GetAllTodosQuery request, CancellationToken cancellationToken)
        {
            var todos = _todoRepository.GetAll().ToList();
            var result = _mapper.Map<List<ToDoDto>>(todos);
            return await Task.FromResult(result);
        }
    }
}
