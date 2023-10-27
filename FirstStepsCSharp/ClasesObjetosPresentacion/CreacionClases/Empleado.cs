namespace ClasesObjetosPresentacion.CreacionClases
{
    public class Empleado
    {
        // Atributos del empleado
        int id;
        float salario;
        string nombre;
        string cedula;
        string direccion;
        string ciudad;
        string provincia;
        string codigoPostal;

        // Método para mostrar información del Empleado
        public string ObtenerInformacion()
        {
            return "Empleado{" + "id=" + id
                    + ", salario=" + salario
                    + ", nombre=" + nombre + ", "
                    + "cedula=" + cedula
                    + ", direccion=" + direccion
                    + ", ciudad=" + ciudad + ", "
                    + "provincia=" + provincia
                    + ", codigoPostal=" + codigoPostal + '}';
        }
    }

}
