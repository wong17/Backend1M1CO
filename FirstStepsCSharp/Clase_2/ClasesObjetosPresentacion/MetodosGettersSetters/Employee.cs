namespace ClasesObjetosPresentacion.MetodosGettersSetters
{
    public class Employee
    {
        /*  
         * Atributos privados y propiedades públicas
         * 
         * Otra forma de crear setters y getters es por medio de "Properties", es decir por cada atributo creamos 
         * una property que sera pública y por medio de ella le podremos dar valor a los atributos privados u
         * obtener su valor.
         * 
         * Los atributos suelen empezar en minuscula y con guion bajo.
         */
        private int _id;
        private string _nombre;
        private string _numeroCedula;
        private float _salario;

        // Propiedad Id
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        // Propiedad Nombre
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        // Propiedad NumeroCedula
        public string NumeroCedula
        {
            get { return _numeroCedula;}
            set { _numeroCedula = value;}
        }
        // Propiedad Salario
        public float Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }

    }
}
