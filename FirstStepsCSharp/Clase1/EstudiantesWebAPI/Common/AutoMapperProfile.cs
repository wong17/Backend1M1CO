using AutoMapper;
using EstudiantesWebAPI.Models;
using EstudiantesWebAPI.Models.Dto;

namespace EstudiantesWebAPI.Common
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Estudiante, EstudianteInsertarDto>().ReverseMap();
        }
    }
}
