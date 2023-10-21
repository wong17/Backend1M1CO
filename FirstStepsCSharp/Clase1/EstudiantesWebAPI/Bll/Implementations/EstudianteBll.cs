using EstudiantesWebAPI.Bll.Interfaces;
using EstudiantesWebAPI.Dal.Repository.Interfaces;
using EstudiantesWebAPI.Models;
using EstudiantesWebAPI.Runtime;

namespace EstudiantesWebAPI.Bll.Implementations
{
    public class EstudianteBll : IEstudianteBll
    {
        private readonly IEstudianteRepository _estudianteRepository;

        public EstudianteBll(IEstudianteRepository estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

        public async Task<APIResponse> Create(Estudiante entity)
        {
            return await _estudianteRepository.Create(entity);
        }

        public async Task<APIResponse> Delete(int id)
        {
            return await (_estudianteRepository.Delete(id));
        }

        public async Task<List<Estudiante>> GetAll()
        {
            return await _estudianteRepository.GetAll();
        }

        public async Task<Estudiante> GetById(int id)
        {
            return await _estudianteRepository.GetById(id);
        }

        public async Task<APIResponse> Update(Estudiante entity)
        {
            return await _estudianteRepository.Update(entity);
        }
    }
}
