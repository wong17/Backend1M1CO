namespace Estudiantes.Dal.Core
{
    public interface IIOFile
    {
        Task<bool> Save<T>(string filePath, T objectToWrite);
        Task<T?> Load<T>(string filePath) where T : new();
    }
}
