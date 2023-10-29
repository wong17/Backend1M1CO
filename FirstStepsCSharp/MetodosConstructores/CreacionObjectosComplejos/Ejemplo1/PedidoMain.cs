namespace MetodosConstructoresHerencia.CreacionObjectosComplejos.Ejemplo1
{
    public class PedidoMain
    {
        public static void Main()
        {
            /* 
             * Para crear un Pedido necesitamos la información del Cliente y la lista de Productos
             * que desea el Cliente, el objeto Pedido depende de otros objetos, primero vamos a crear
             * esos otros objetos para finalmente poder crear un Pedido.
             */

            #region PedidoEjemplo1

            // Crear objeto Cliente
            Cliente cliente = new()
            {
                Nombre = "Juan Perez",
                Direccion = "Calle Principal 123",
                CorreoElectronico = "juan@example.com"
            };

            // Crear objetos de Producto
            Producto producto1 = new()
            {
                Nombre = "Laptop",
                Precio = 1000.0,
                CantidadEnStock = 10,
                Descripcion = "Portatil de alta gama."
            };

            Producto producto2 = new()
            {
                Nombre = "Telefono",
                Precio = 500.0,
                CantidadEnStock = 20,
                Descripcion = "Telefono inteligente."
            };

            Producto producto3 = new()
            {
                Nombre = "Tablet",
                Precio = 300.0,
                CantidadEnStock = 15,
                Descripcion = "Tablet."
            };

            Producto producto4 = new()
            {
                Nombre = "Monitor",
                Precio = 200.0,
                CantidadEnStock = 5,
                Descripcion = "Monitor de alta resolucion."
            };

            Producto producto5 = new()
            {
                Nombre = "Impresora",
                Precio = 150.0,
                CantidadEnStock = 8,
                Descripcion = "Impresora a color."
            };

            // Crear arreglo para guardar todos los productos
            Producto[] productos = {
                producto1, producto2, producto3, producto4, producto5
            };

            // Crear un objeto de Pedido que depende de Cliente y varios Productos
            Pedido pedido = new(cliente, productos, "Calle Secundaria 456", DateTime.Now);

            // Mostrar información del Pedido
            pedido.MostrarPedido();

            #endregion

        }
    }
}
