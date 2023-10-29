﻿namespace MetodosConstructores.Constructores.SobrecargaDeConstructores
{
    public class Empleado
    {
        // Atributos de la clase Empleado
        private int id;
        private string? nombre;
        private string? apellido;
        private string? puesto;
        private double salario;
        private string? departamento;

        /* Constructor por defecto (sin parámetros) */
        public Empleado()
        {

        }

        /* Constructor que recibe 3 atributos como parámetros */
        public Empleado(int id, string? nombre, string? puesto)
        {
            this.id = id;
            this.nombre = nombre;
            this.puesto = puesto;
        }

        /* Constructor que recibe 4 atributos como parámetros */
        public Empleado(int id, string? nombre, string? apellido, string? puesto)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.puesto = puesto;
        }

        /* Constructor que recibe 5 atributos como parámetros */
        public Empleado(int id, string? nombre, string? apellido, string? puesto, double salario)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.puesto = puesto;
            this.salario = salario;
        }

        /* Constructor que recibe todos los atributos como parámetros */
        public Empleado(int id, string? nombre, string? apellido, string? puesto, double salario, string? departamento)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.puesto = puesto;
            this.salario = salario;
            this.departamento = departamento;
        }

        // Propiedades públicas para acceder a los atributos
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string? Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string? Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string? Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public string? Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
    }
}
