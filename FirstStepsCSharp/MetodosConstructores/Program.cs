using MetodosConstructores.Constructores.ConstructorPorDefecto;
using MetodosConstructores.Constructores.CreacionDeConstructor;
using MetodosConstructores.Constructores.SobrecargaDeConstructores;
using MetodosConstructores.MetodosAtributosStatic.Atributos;
using MetodosConstructores.MetodosAtributosStatic.Metodos;
using MetodosConstructoresHerencia.CreacionObjectosComplejos.Ejemplo1;
using MetodosConstructoresHerencia.CreacionObjectosComplejos.Ejemplo2;
using MetodosConstructoresHerencia.CreacionObjectosComplejos.Ejemplo3;
using MetodosConstructoresHerencia.Herencia.Ejemplo1;
using MetodosConstructoresHerencia.Herencia.Ejemplo2;
using MetodosConstructoresHerencia.Herencia.Ejemplo3;

// 1. Métodos constructores
Console.WriteLine("----------------------------- CONSTRUCTORES POR DEFECTO -----------------------------");
ConstructorPorDefectoMain.Main();

Console.WriteLine("----------------------------- CREACIÓN DE UN CONSTRUCTOR -----------------------------");
CreacionDeConstructorMain.Main();

Console.WriteLine("----------------------------- SOBRECARGA DE CONSTRUCTORES -----------------------------");
SobrecargaDeConstructoresMain.Main();

// 2. Creación de objetos que dependen de otros objetos
Console.WriteLine("----------------------------- CREACION DE OBJETOS COMPLEJOS -----------------------------");
PedidoMain.Main();
BibliotecaMain.Main();
UniversidadMain.Main();

// 3. Métodos y atributos static
Console.WriteLine("----------------------------- METODOS STATIC -----------------------------");
MetodoStaticMain.Main();

Console.WriteLine("----------------------------- ATRIBUTOS STATIC -----------------------------");
AtributosStaticMain.Main();

// 4. Herencia
Console.WriteLine("----------------------------- HERENCIA -----------------------------");
AnimalMain.Main();
AnimalConConstructorMain.Main();
ComputadoraMain.Main();