namespace Proyecto___2
{
    internal class Program
    {
        public static Dictionary<byte, List<Producto>> productosConsumidosPorMesa = new Dictionary<byte, List<Producto>>();
        static void Main(string[] args)
        {
            byte numeroMesa = 0;
            List<Producto> productosVenta = new List<Producto>(); // Lista para guardar los productos agregados en mesa
            List<Producto> productos = new List<Producto>();

            for (byte i = 0; i < 1;)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" \r\n __   __  _______  __    _  __   __            ___     ____                         \r\n|  |_|  ||       ||  |  | ||  | |  |          |   |   |    |                        \r\n|       ||    ___||   |_| ||  | |  |          |___|   |_    |                       \r\n|       ||   |___ |       ||  |_|  |           ___      |   |                       \r\n|       ||    ___||  _    ||       |          |   |     |   |                       \r\n| ||_|| ||   |___ | | |   ||       |          |___|    _|   |                       \r\n|_|   |_||_______||_|  |__||_______|                  |____|                        \r\n _______  ______    ___   __    _  _______  ___   _______  _______  ___             \r\n|       ||    _ |  |   | |  |  | ||       ||   | |       ||   _   ||   |            \r\n|    _  ||   | ||  |   | |   |_| ||       ||   | |    _  ||  |_|  ||   |            \r\n|   |_| ||   |_||_ |   | |       ||       ||   | |   |_| ||       ||   |            \r\n|    ___||    __  ||   | |  _    ||      _||   | |    ___||       ||   |___         \r\n|   |    |   |  | ||   | | | |   ||     |_ |   | |   |    |   _   ||       |        \r\n|___|    |___|  |_||___| |_|  |__||_______||___| |___|    |__| |__||_______|        \r\n _______  ___   _______  __    _  __   __  _______  __    _  ___   ______   _______ \r\n|  _    ||   | |       ||  |  | ||  | |  ||       ||  |  | ||   | |      | |       |\r\n| |_|   ||   | |    ___||   |_| ||  |_|  ||    ___||   |_| ||   | |  _    ||   _   |\r\n|       ||   | |   |___ |       ||       ||   |___ |       ||   | | | |   ||  | |  |\r\n|  _   | |   | |    ___||  _    ||       ||    ___||  _    ||   | | |_|   ||  |_|  |\r\n| |_|   ||   | |   |___ | | |   | |     | |   |___ | | |   ||   | |       ||       |\r\n|_______||___| |_______||_|  |__|  |___|  |_______||_|  |__||___| |______| |_______|\r\n   ");
                Console.ResetColor();
                Console.WriteLine("+-------------------------------------------------------------------------------------+");

             

                Console.WriteLine("Seleccione una opción: ");
                Console.WriteLine("1. Gestion Menu y productos");
                Console.WriteLine("2. Pedido mesa");
                Console.WriteLine("3. Factura ");
                Console.WriteLine("4. Inventario");
                Console.WriteLine("0. Salir");

                string opcion = Console.ReadLine();

                switch (opcion) //Aquí hacemos los casos posibles para la selección del menú
                {
                    case "0": Environment.Exit(0); ; break;
                    case "3": // Factura
                        Console.Write("Ingrese el número de mesa para generar la factura: ");
                        while (!byte.TryParse(Console.ReadLine(), out numeroMesa) || numeroMesa < 1 || numeroMesa > 20)
                        {
                            Console.WriteLine("Por favor, ingrese un número de mesa válido (entre 1 y 20).");
                            Console.Write("Ingrese el número de mesa para generar la factura: ");
                        }
                        Factura factura = new Factura(productosConsumidosPorMesa);
                        factura.GenerarFactura(numeroMesa);
                        break;
                    case "2": //ejecuta la función de agregar o elimina los productos de cada mesa 

                        AgregarProductosAMesa(productosConsumidosPorMesa, productos);

                        break;

                    case "1": // Gestiona el menu logrando agregar eliminar y ver la carta del restaurante 
                        for (byte j = 0; j < 1;)
                        {
                            Console.WriteLine("Seleccione una opción: ");
                            Console.WriteLine("1. Agregar Productos ");
                            Console.WriteLine("2. Eliminar productos");
                            Console.WriteLine("3. Mostrar carta");
                            Console.WriteLine("0. Volver al menu principal");

                            string opcionProductos = Console.ReadLine();
                            switch (opcionProductos)
                            {
                                case "0":
                                    j++;
                                    break;
                                case "1":
                                    AgregarProductos(productos);
                                    break;
                                case "2":
                                    EliminarProducto(productos);
                                    break;
                                case "3":
                                    MostrarMenu(productos);
                                    break;
                                default: Console.WriteLine("Seleccione una opcion valida"); break;
                            }
                        }
                        break;

                    default: Console.WriteLine("Seleccione una opción valida"); break;
                }
                Console.WriteLine();
            }

            //Verifica si la mesa si existe 
            for (byte i = 0; i < 1;)
            {
                Console.WriteLine("Seleccione una mesa entre 1 y 12 ");
                string mesa = Console.ReadLine();

                bool verifMesa = byte.TryParse(mesa, out numeroMesa);
                if (numeroMesa > 12 || verifMesa == false)
                {
                    Console.WriteLine("Seleccione una opcion valida");
                }
                else { i++; }

            }






        }



        static void AgregarProductos(List<Producto> productos)
        {
            Console.WriteLine("Agrege el producto deseado:");

            while (true)
            {
                Console.Write("Nombre del producto : ");
                string nombre = Console.ReadLine();

                // Si el usuario no escribe el nombre , salir del bucle
                if (string.IsNullOrEmpty(nombre))
                    break;

                Console.Write("Precio del producto: ");
                float precio;
                while (!float.TryParse(Console.ReadLine(), out precio) || precio < 0)
                {
                    Console.WriteLine("Por favor, ingrese un precio válido.");
                    Console.Write("Ingrese Precio del producto: ");
                }


                Console.Write("Escribe el ID del producto : ");
                string idStr = Console.ReadLine();

                // Si el usuario deja el ID vacío, salir del bucle
                if (string.IsNullOrEmpty(idStr))
                    break;

                int id;
                if (!int.TryParse(idStr, out id) || id <= 0)
                {
                    Console.WriteLine("Por favor, ingrese un ID correcto .");
                    continue;
                }

                // Agregar nuevo producto a la carta 

                Producto producto = new Producto(nombre, precio, id);

                productos.Add(producto);

                Console.WriteLine("Producto agregado con éxito.");
            }
        }
        static void MostrarMenu(List<Producto> productos)
        {
            // Enseña los productos actuales para que el usuario pueda seleccionar eliminar
            Console.WriteLine("Lista de Productos:");

            for (int i = 0; i < productos.Count; i++)
            {
                Console.WriteLine($"ID: {productos[i].Id} - Nombre: {productos[i].Nombre} - Precio: {productos[i].Precio}");
            }
        }
        static void EliminarProducto(List<Producto> productos)
        {
            // Mostrar los productos actuales para que el usuario pueda seleccionar uno para eliminar
            Console.WriteLine("Lista de Productos:");

            for (int i = 0; i < productos.Count; i++)
            {
                Console.WriteLine($"ID: {productos[i].Id} - Nombre: {productos[i].Nombre} - Precio: {productos[i].Precio}");
            }

            // Solicitar al usuario que ingrese el ID del producto a eliminar
            Console.Write("Ingrese el ID del producto que desea eliminar (0 para cancelar): ");
            int idEliminar;
            while (!int.TryParse(Console.ReadLine(), out idEliminar) || idEliminar < 0)
            {
                Console.WriteLine("Por favor, ingrese un ID válido.");
                Console.Write("Ingrese el ID del producto que desea eliminar (0 para cancelar): ");
            }

            // Si el ID es 0, cancelar la operación
            if (idEliminar == 0)
            {
                Console.WriteLine("Operación cancelada.");
                return;
            }

            // Buscar el producto con el ID especificado en la lista
            Producto productoEliminar = productos.Find(p => p.Id == idEliminar);

            // Si el producto no se encontró, mostrar un mensaje de error y salir de la función
            if (productoEliminar == null)
            {
                Console.WriteLine("No se encontró ningún producto intente de nuevo");
                return;
            }

            // Confirmar la eliminación del producto
            Console.WriteLine($"¿Está seguro de que desea eliminar el producto '{productoEliminar.Nombre}' con ID {productoEliminar.Id}? (s/n)");
            string confirmacion = Console.ReadLine();

            // Si el usuario confirma la eliminación, eliminar el producto de la lista
            if ( confirmacion.ToLower() == "s")
            {
                productos.Remove(productoEliminar);
                Console.WriteLine("Producto eliminado.");
            }
            else
            {
                Console.WriteLine("Proceso cancelado.");
            }
        }


        //Esta es la función encargada de agregar los productos a cada mesa para después poder generar la factura correctamente
        static void AgregarProductosAMesa(Dictionary<byte, List<Producto>> productosConsumidosPorMesa, List<Producto> productos)
        {
            Console.WriteLine("Seleccione el número de mesa para agregar o eliminar productos:");
            byte mesa;
            while (!byte.TryParse(Console.ReadLine(), out mesa) || mesa < 1 || mesa > 12)
            {
                Console.WriteLine("Por favor, ingrese un número de mesa válido (entre 1 y 12).");
                Console.Write("Seleccione el número de mesa para agregar o eliminar productos: ");
            }


            // Verificar si la mesa ya tiene una lista de productos consumidos, si no, crea una nueva lista
            if (!productosConsumidosPorMesa.ContainsKey(mesa))
            {
                productosConsumidosPorMesa[mesa] = new List<Producto>();
            }

            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("0. Volver al menú principal");
                string opcion = Console.ReadLine();
                // Aquí son los casos para el apartado de agregar productos a la mesa, cada producto que la mesa ha consumido
                switch (opcion)
                {
                    case "1":
                        MostrarProductos(productos);
                        AgregarProductoPorID(productosConsumidosPorMesa[mesa], productos);
                        break;
                    case "2":
                        MostrarProductos(productosConsumidosPorMesa[mesa]);
                        EliminarProductoPorID(productosConsumidosPorMesa[mesa]);
                        break;
                    case "0":
                        return; // Salir de la función y volver al menú principal
                    default:
                        Console.WriteLine("Proceso Incorrecto."); //En caso tal de quel usuario cometa un error escribiendo el numero 
                        break;
                }
            }
        }


        static void MostrarProductos(List<Producto> productos)
        {
            Console.WriteLine("Lista de productos:");
            foreach (var producto in productos)
            {
                Console.WriteLine($"ID: {producto.Id} - Nombre: {producto.Nombre} - Precio: {producto.Precio}");
            }
        }

        static void AgregarProductoPorID(List<Producto> productosMesa, List<Producto> productos)
        {
            Console.WriteLine("Ingrese el ID del producto que desea agregar:");
            int idProducto;
            while (!int.TryParse(Console.ReadLine(), out idProducto) || idProducto <= 0)
            {
                Console.WriteLine("Por favor, ingrese un ID válido (número entero positivo).");
                Console.Write("Ingrese el ID del producto que desea agregar: ");
            }

            Producto productoAAgregar = productos.Find(p => p.Id == idProducto);
            if (productoAAgregar != null)
            {
                productosMesa.Add(productoAAgregar);
                Console.WriteLine($"Producto '{productoAAgregar.Nombre}' agregado a la mesa.");
            }
            else
            {
                Console.WriteLine("No se encontró el producto .");
            }
        }

        static void EliminarProductoPorID(List<Producto> productosMesa)
        {
            Console.WriteLine("Ingrese el ID del producto que desea eliminar:");
            int idProducto;
            while (!int.TryParse(Console.ReadLine(), out idProducto) || idProducto <= 0)
            {
                Console.WriteLine(" ingrese el ID correcto  ( Un número natural ).");
                Console.Write("Ingrese el ID del producto que desea eliminar: ");
            }

            Producto productoAEliminar = productosMesa.Find(p => p.Id == idProducto);
            if (productoAEliminar != null)
            {
                productosMesa.Remove(productoAEliminar);
                Console.WriteLine($"Producto '{productoAEliminar.Nombre}' se elimino de la mesa.");
            }
            else
            {
                Console.WriteLine("No se encontró ningún producto con el ID inscrito ."); 
            }
        }
    }
}
