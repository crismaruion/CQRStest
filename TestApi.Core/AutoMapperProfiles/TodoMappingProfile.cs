using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TestApi.Core.Domain;
using TestApi.Core.DtoModels;

namespace TestApi.Core.AutoMapperProfiles
{
    public class TodoMappingProfile : Profile
    {
        public TodoMappingProfile()
        {
            CreateMap<TodoEntity, ToDoDto>();

            CreateMap<CreateUpdateToDoDto, TodoEntity>();
        }
    }
}
