using Estudiantes.Dal.Core;
using Estudiantes.Dal.Repository.Implementations;
using Estudiantes.Dal.Repository.Interfaces;
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
