namespace FirstStepsCSharp.POO.Encapsulation.GettersAndSetters
{
    public class Person
    {
        // Atributos privados de la clase Person
        private string Name;        
        private string IDNumber;
        private double Height;

        /* 
         * Getters y Setters
         * 
         * Getter: Un método que retorna el valor de un atributo que es privado
         * Setter: Un método que permite darle un valor a un atributo que es privado
         * 
         * Ambos deben ser métodos publicos para poder utilizarlos desde otra clase al momento
         * de crear un objeto y asi obtener el valor de un atributo private o darle un valor.
         * 
         * ----------- ACLARACIÓN ---------- :
         *  Un método y una función son lo mismo, simplemente que cuando se crea una función dentro
         *  de una clase se le dice método y no función, pero es lo mismo, es cuestion del parádigma.
         *  
         *  Como se dice que una clase tiene "métodos y atributos" pues a las funciones que creemos 
         *  dentro de la clase le llamaremos "métodos" pero ambos terminos se refieren a la misma cosa.
         *  
         *  Los getters y setters no son más que funciones, métodos en el contexto de POO.
         */

        /* --------------- GETTERS --------------- */

        // Método que retorna el nombre, ya que el campo es privado y no se puede acceder directamente
        public string GetName()
        {
            return Name;
        }
        // Método que retorna el número de cedula, ya que el campo es privado y no se puede acceder directamente
        public string GetIDNumber() 
        { 
            return IDNumber; 
        }
        // Método que retorna la altura, ya que el campo es privado y no se puede acceder directamente
        public double GetHeight()
        {
            return Height;
        }

        /* --------------- SETTERS --------------- */

        // Método para darle un valor al campo nombre ya que es privado y no es accesible directamente
        public void SetName(string name)
        {
            Name = name;
        }
        // Método para darle un valor al campo número de cedula ya que es privado y no es accesible directamente
        public void SetIDNumber(string idNumber)
        { 
            IDNumber = idNumber; 
        }
        // Método para darle un valor al campo altura ya que es privado y no es accesible directamente
        public void SetHeight(double height) 
        { 
            Height = height;
        }
    }
}