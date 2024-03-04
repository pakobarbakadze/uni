using AutoMapper;
using uni.Dtos;
using uni.Entities;

namespace uni
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddStudentDto, Student>();
        }
    }
}