using AutoMapper;
using TodoApp.Dto;
using TodoApp.Entity.Classes;
using TodoApp.Entity.Db;

namespace TodoApp
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TaskGroupEntity, TaskGroupViewDto>().ReverseMap();
            CreateMap<TaskEntity, TaskViewDto>().ReverseMap();
            CreateMap<TaskEntity, TaskCreateDto>().ReverseMap();
            CreateMap<TaskEntity, TaskUpdateDto>().ReverseMap();
        }
    }
}
