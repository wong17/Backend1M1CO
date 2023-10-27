namespace ClasesObjetosPresentacion.MetodosGettersSetters
{
    public class Empleado
    {
        /*  
         * Atributos privados
         * La unica forma de acceder a ellos desde otra clase es a travez de métodos públicos
         * 
         * Setter: método que nos permite establecer un valor a un atributo privado
         * Getter: método que nos permite obtener el valor de un atributo privado
         */
        private int id;
        private string nombre;
        private string numeroCedula;
        private float salario;

        /* Setters */
        public void SetId(int id)
        { 
            this.id = id; 
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetNumeroCedula(string numeroCedula)
        {
            this.numeroCedula = numeroCedula;
        }

        public void SetSalario(float salario)
        {
            this.salario = salario;
        }

        /* Getters */
        public int GetId()
        {
            return id;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetNumeroCedula()
        {
            return numeroCedula;
        }

        public float GetSalario()
        {
            return salario;
        }
    }
}
