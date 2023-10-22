using Estudiantes.Dal.Core;
using EstudiantesWebAPI.Dal.Repository.Implementations;
using EstudiantesWebAPI.Dal.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Estudiantes.Dal.Configurations
{
    /* Encargada de registrar los servicios de DAL para inyección de dependencias */
    public static class ConfigureServicesDataAccess
    {
        public static IServiceCollection AddDataAccessLayer(this IServiceCollection services)
        {
            /* Core */
            services.AddScoped<IIOFile, IOJsonFile>();
            /* Agregar servicios DALs */
            services.AddScoped<IEstudianteRepository, EstudianteRepository>();

            return services;
        }
    }
}
