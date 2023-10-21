﻿using EstudiantesWebAPI.Models;

namespace EstudiantesWebAPI.Dal.Repository.Interfaces
{
    public interface IEstudianteRepository : IRepository<Estudiante>
    {
        /* Para obtener todos los registros */
        Task<List<Estudiante>> GetAll();
        /* Para obtener un solo registro */
        Task<Estudiante?> GetById(int id);
    }
}
