using EstudiantesDesktopApp.ApiConnection;
using EstudiantesDesktopApp.Entities.Models;
using EstudiantesWebAPI.Common.Runtime;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstudiantesDesktopApp.Services
{
    public class StudentService
    {
        private AppSettings _AppSettings;

        public StudentService()
        {
            _AppSettings = new AppSettings();
        }

        // GET
        public async Task<IEnumerable<Estudiante>> Get()
        {
            try
            {
                string uri = $"{_AppSettings.UrlApi}{_AppSettings.EstudianteEndpointUrl}";
                List<Estudiante> students = await HttpRequests.RequestAsync<List<Estudiante>>(HttpMethod.Get, uri);
                return students;
            } catch (Exception ex)
            {
                _ = ex;
                return new List<Estudiante>();
            }
        }

        public async Task<Estudiante> GetById(int id)
        {
            try
            {
                string uri = $"{_AppSettings.UrlApi}{_AppSettings.EstudianteEndpointUrl}/{id}";
                Estudiante students = await HttpRequests.RequestAsync<Estudiante>(HttpMethod.Get, uri);
                return students;
            }
            catch (Exception ex)
            {
                _ = ex;
                return new Estudiante();
            }
        }

        // POST
        public async Task<APIResponse> Create(Estudiante student)
        {
            try
            {
                string uri = $"{_AppSettings.UrlApi}{_AppSettings.EstudianteEndpointUrl}";
                Estudiante studentResult = await HttpRequests.RequestAsync<Estudiante>(HttpMethod.Post, uri, student);
                if (studentResult is not null)
                {
                    return new APIResponse
                    {
                        IsSuccess = true,
                        Message = "Estudiante registrado exitosamente."
                    };
                }
                return new APIResponse
                {
                    IsSuccess = false,
                    Message = "Ocurrió un error inesperado."
                };
            } catch (Exception ex)
            {
                _ = ex;
                return new APIResponse { IsSuccess = false, Message = ex.Message };
            }
        }

        // PUT
        public async Task<APIResponse> Update(Estudiante student)
        {
            try
            {
                string uri = $"{_AppSettings.UrlApi}{_AppSettings.EstudianteEndpointUrl}";
                Estudiante studentResult = await HttpRequests.RequestAsync<Estudiante>(HttpMethod.Put, uri, student);
                if (studentResult is not null)
                {
                    return new APIResponse
                    {
                        IsSuccess = true,
                        Message = "Estudiante actualizado exitosamente."
                    };
                }
                return new APIResponse
                {
                    IsSuccess = false,
                    Message = "Ocurrió un error inesperado."
                };
            }
            catch (Exception ex)
            {
                _ = ex;
                return new APIResponse { IsSuccess = false, Message = ex.Message };
            }
        }

        // DELETE
        public async Task<APIResponse> Delete(int id)
        {
            try
            {
                string uri = $"{_AppSettings.UrlApi}{_AppSettings.EstudianteEndpointUrl}/{id}";
                APIResponse response = await HttpRequests.RequestAsync<APIResponse>(HttpMethod.Delete, uri);
                return response;
            }
            catch (Exception ex)
            {
                _ = ex;
                return new APIResponse { IsSuccess = false, Message = ex.Message };
            }
        }
    }
}