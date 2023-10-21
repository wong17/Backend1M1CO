using EstudiantesWebAPI.Models;
using EstudiantesWebAPI.Runtime;

namespace EstudiantesWebAPI.Bll.Interfaces
{
    /* Business logic layer BLL */
    public interface IEstudianteBll : IBaseBll
    {
        /* Para insertar un registro */
        Task<APIResponse> Create(Estudiante entity);
        /* Para actualizar un registro */
        Task<APIResponse> Update(Estudiante entity);
        /* Para eliminar un registro */
        Task<APIResponse> Delete(int id);
        /* Para obtener todos los registros */
        Task<List<Estudiante>> GetAll();
        /* Para obtener un solo registro */
        Task<Estudiante> GetById(int id);
    }
}
