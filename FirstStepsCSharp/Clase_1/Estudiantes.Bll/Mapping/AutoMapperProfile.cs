using AutoMapper;
using Estudiantes.Entities.Models;
using Estudiantes.Entities.Models.Dto;

namespace Estudiantes.Bll.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Estudiante, EstudianteInsertarDto>().ReverseMap();
        }
    }
}
