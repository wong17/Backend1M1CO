using System.Text.Json;

namespace EstudiantesWebAPI.Dal.Core
{
    /* Clase para lectura y escritura de objetos en formato json en un archivo (Input/Output) 
     - Es un código de ejemplo, podrian agregarse más validaciones. 
     */
    public class IOJsonFile : IIOFile
    {
        /* Escribe dentro del archivo el objeto en formato json */
        public async Task<bool> Save<T>(string filePath, T objectToWrite)
        {
            // Evaluar que el archivo existe
            if (!File.Exists(filePath))
                return false;
            // Evaluar que el contenido no es null
            if (objectToWrite is null)
                return false;
            // Escribir contenido en el archivo
            var options = new JsonSerializerOptions
            {
                WriteIndented = true 
            };
            using FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            await JsonSerializer.SerializeAsync(fileStream, objectToWrite, options);
            return true;
        }
        /* Lee el contenido del archivo y devuelve una lista con todo el contenido */
        public async Task<T?> Load<T>(string filePath) where T : new ()
        {
            // Evaluar que el archivo existe
            if (!File.Exists(filePath))
                return new T();
            // Leer contenido del archivo y devolver una lista con los elementos
            using FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            return await JsonSerializer.DeserializeAsync<T>(fileStream);
        }
    }
}
