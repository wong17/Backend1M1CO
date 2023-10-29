using Estudiantes.Common.Runtime;
using Estudiantes.Dal.Core;
using Estudiantes.Dal.Repository.Interfaces;
using Estudiantes.Entities.Models;
using Microsoft.Extensions.Configuration;
using System.Net;

namespace Estudiantes.Dal.Repository.Implementations
{
    /* Este código es a modo de ejemplo, habria que realizar mas validaciones y cambiar la forma en la
     * que se estan haciendo unas cosas pero para la demostración nos sirve. */
    public class EstudianteRepository : IEstudianteRepository
    {
        private readonly IIOFile _fileIO;
        private readonly IConfiguration _configuration;
        private readonly string _filePath;

        public EstudianteRepository(IConfiguration configuration, IIOFile fileIO)
        {
            _configuration = configuration;
            _fileIO = fileIO;
            _filePath = _configuration.GetConnectionString("JsonDB") ?? "EstudiantesDatabase.json";
        }

        public async Task<APIResponse> Create(Estudiante entity)
        {
            var students = await _fileIO.Load<List<Estudiante>?>(_filePath);
            /* Si la ruta del archivo no existe */
            if (students is null)
            {
                var apiResponse = new APIResponse()
                {
                    IsSuccess = false,
                    Message = "Error: Revise la ruta del archivo.",
                    StatusCode = HttpStatusCode.InternalServerError,
                    Result = null
                };
                return apiResponse;
            }
            /* Asignar ID al nuevo estudiante */
            entity.Id = students.Last().Id + 1;
            students.Add(entity);
            /* Sino se pudo guardar en el archivo */
            var response = _fileIO.Save(_filePath, students);
            if (!response.Result)
            {
                var apiResponse = new APIResponse()
                {
                    IsSuccess = false,
                    Message = "Ocurrio un error al guardar en el archivo.",
                    StatusCode = HttpStatusCode.InternalServerError,
                    Result = null
                };
                return apiResponse;
            }
            /* Si se registro correctamente en el archivo */
            var successApiResponse = new APIResponse()
            {
                IsSuccess = true,
                Message = "Estudiante registrado exitosamente.",
                StatusCode = HttpStatusCode.Created,
                Result = entity
            };
            return successApiResponse;
        }

        public async Task<APIResponse> Delete(int id)
        {
            var students = await _fileIO.Load<List<Estudiante>?>(_filePath);
            /* En caso de cualquier problema relacionado con el archivo */
            if (students is null || students.Count == 0)
                return new APIResponse()
                {
                    StatusCode = HttpStatusCode.NotFound,
                    IsSuccess = false,
                    Message = "No se encontro un Estudiante con el ID ingresado.",
                    Result = null
                };
            /* En caso de no encontrar el registro */
            var studentIndex = students.FindIndex(e => e.Id == id);
            if (studentIndex == -1)
                return new APIResponse()
                {
                    StatusCode = HttpStatusCode.NotFound,
                    IsSuccess = false,
                    Message = "No se encontro un Estudiante con el ID ingresado.",
                    Result = null
                };
            /* Eliminar registro */
            students.RemoveAt(studentIndex);
            /* Guardar cambios en el archivo */
            var response = _fileIO.Save(_filePath, students);
            if (!response.Result)
            {
                var apiResponse = new APIResponse()
                {
                    IsSuccess = false,
                    Message = "Ocurrio un error al guardar en el archivo.",
                    StatusCode = HttpStatusCode.InternalServerError,
                    Result = null
                };
                return apiResponse;
            }
            /* Si todo salio bien */
            return new APIResponse()
            {
                StatusCode = HttpStatusCode.OK,
                IsSuccess = true,
                Message = $"Estudiante con ID:{id} eliminado exitosamente. ",
                Result = id
            };
        }

        public async Task<List<Estudiante>> GetAll()
        {
            var students = await _fileIO.Load<List<Estudiante>?>(_filePath);
            /* En caso de cualquier problema relacionado con el archivo */
            if (students is null)
                return new List<Estudiante>();
            return students;
        }

        public async Task<Estudiante?> GetById(int id)
        {
            var students = await _fileIO.Load<List<Estudiante>?>(_filePath);
            /* En caso de cualquier problema relacionado con el archivo */
            if (students is null || students.Count == 0)
                return new Estudiante();
            /* Devuelve la información del Estudiante si se encontro, caso contrario devuelve null */
            return students.FirstOrDefault(e => e.Id == id);
        }

        public async Task<APIResponse> Update(Estudiante entity)
        {
            var students = await _fileIO.Load<List<Estudiante>?>(_filePath);
            /* En caso de cualquier problema relacionado con el archivo */
            if (students is null || students.Count == 0)
                return new APIResponse()
                {
                    StatusCode = HttpStatusCode.NotFound,
                    IsSuccess = false,
                    Message = "No se encontro un Estudiante con el ID ingresado.",
                    Result = null
                };
            /* En caso de no encontrar el registro */
            var student = students.FirstOrDefault(e => e.Id == entity.Id);
            if (student is null)
                return new APIResponse()
                {
                    StatusCode = HttpStatusCode.NotFound,
                    IsSuccess = false,
                    Message = "No se encontro un Estudiante con el ID ingresado.",
                    Result = null
                };
            /* Actualizar la información del Estudiante */
            student.Carnet = entity.Carnet;
            student.Carrera = entity.Carrera;
            student.Nombre = entity.Nombre;
            /* Guardar registro actualizado */
            var response = _fileIO.Save(_filePath, students);
            if (!response.Result)
            {
                var apiResponse = new APIResponse()
                {
                    IsSuccess = false,
                    Message = "Ocurrio un error al guardar en el archivo.",
                    StatusCode = HttpStatusCode.InternalServerError,
                    Result = null
                };
                return apiResponse;
            }
            /* Si todo salio bien */
            return new APIResponse()
            {
                StatusCode = HttpStatusCode.OK,
                IsSuccess = true,
                Message = $"Estudiante con ID:{entity.Id} actualizado exitosamente. ",
                Result = entity.Id
            };
        }
    }
}
