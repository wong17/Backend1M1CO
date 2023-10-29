using Estudiantes.Bll.Implementations;
using Estudiantes.Bll.Interfaces;
using Estudiantes.Bll.Mapping;
using Estudiantes.Dal.Configurations;
using Microsoft.Extensions.DependencyInjection;

namespace Estudiantes.Bll.Configurations
{
    /* Encargada de registrar los servicios de BLL para inyección de dependencias.*/

    public static class ConfigureServicesBusinessLogic
    {
        public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection services)
        {
            /* Agregar primero servicios de Data Access Layer (DAL) */
            services.AddDataAccessLayer();
            /* Agregar BLLs */
            services.AddScoped<IEstudianteBll, EstudianteBll>();
            /* Agregar configuración de AutoMapper */
            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}