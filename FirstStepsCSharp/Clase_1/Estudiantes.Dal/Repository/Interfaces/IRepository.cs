using Estudiantes.Common.Runtime;

namespace Estudiantes.Dal.Repository.Interfaces
{
    public interface IRepository<in T> where T : class
    {
        /* Para insertar un registro */
        Task<APIResponse> Create(T entity);
        /* Para actualizar un registro */
        Task<APIResponse> Update(T entity);
        /* Para eliminar un registro */
        Task<APIResponse> Delete(int id);
    }
}
