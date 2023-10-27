using AutoMapper;
using EstudiantesDesktopApp.Entities.Models;
using EstudiantesWebAPI.Entities.Models.Dto;

namespace Estudiantes.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Estudiante, EstudianteInsertarDto>().ReverseMap();
        }
    }
}
