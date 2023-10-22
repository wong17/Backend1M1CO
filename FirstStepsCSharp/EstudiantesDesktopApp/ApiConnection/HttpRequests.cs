using System.Net.Http.Headers;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Text.Json;

namespace EstudiantesDesktopApp.ApiConnection
{
    /// <summary>
    /// Método HTTP.
    /// </summary>
    public enum HttpMethod
    {
        /// <summary>
        /// Petición GET
        /// </summary>
        Get,

        /// <summary>
        /// Petición PUT
        /// </summary>
        Put,

        /// <summary>
        /// Petición POST
        /// </summary>
        Post,

        /// <summary>
        /// Petición DELETE
        /// </summary>
        Delete
    }

    public static class HttpRequests
    {
        public static async Task<TResult> RequestAsync<TResult>(HttpMethod method, string uri, object? data = null)
        {
            try
            {
                HttpClient client = new()
                {
                    BaseAddress = new Uri(uri)
                };
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage? response = null;

                response = method switch
                {
                    HttpMethod.Get => await client.GetAsync(uri),
                    HttpMethod.Post => await client.PostAsJsonAsync(uri, data),
                    HttpMethod.Put => await client.PutAsJsonAsync(uri, data),
                    HttpMethod.Delete => await client.DeleteAsync(uri),
                    _ => throw new ArgumentOutOfRangeException(nameof(HttpMethod), "El parámetro proporcionado no es válido."),
                };
                if (response is not null && response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var result = JsonSerializer.Deserialize<TResult>(content);
                    if (result is null)
                        throw new InvalidOperationException("Los datos no se pudieron deserializar correctamente.");
                    return result;

                }
                else if (response is not null && !response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    throw new Exception($"{response.StatusCode.GetHashCode()} - {response.StatusCode}\nContent: {content}");
                }
                throw new Exception(uri);
            }
            catch (Exception ex)
            {
                throw new Exception(uri, ex);
            }
        }
    }
}