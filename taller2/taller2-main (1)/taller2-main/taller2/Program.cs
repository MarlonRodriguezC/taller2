using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace taller2
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Carta carta = new Carta();
            Administracion administracion = new Administracion();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("$$\\       $$\\                                                   $$\\       $$\\           \r\n$$ |      \\__|                                                  \\__|      $$ |          \r\n$$$$$$$\\  $$\\  $$$$$$\\  $$$$$$$\\ $$\\    $$\\  $$$$$$\\  $$$$$$$\\  $$\\  $$$$$$$ | $$$$$$\\  \r\n$$  __$$\\ $$ |$$  __$$\\ $$  __$$\\\\$$\\  $$  |$$  __$$\\ $$  __$$\\ $$ |$$  __$$ |$$  __$$\\ \r\n$$ |  $$ |$$ |$$$$$$$$ |$$ |  $$ |\\$$\\$$  / $$$$$$$$ |$$ |  $$ |$$ |$$ /  $$ |$$ /  $$ |\r\n$$ |  $$ |$$ |$$   ____|$$ |  $$ | \\$$$  /  $$   ____|$$ |  $$ |$$ |$$ |  $$ |$$ |  $$ |\r\n$$$$$$$  |$$ |\\$$$$$$$\\ $$ |  $$ |  \\$  /   \\$$$$$$$\\ $$ |  $$ |$$ |\\$$$$$$$ |\\$$$$$$  |\r\n\\_______/ \\__| \\_______|\\__|  \\__|   \\_/     \\_______|\\__|  \\__|\\__| \\_______| \\______/ ");
            Console.ResetColor();
            Console.WriteLine("  ______   ______   ______   ______   ______   ______   ______   ______   ______   ______ \r\n |______| |______| |______| |______| |______| |______| |______| |______| |______| |______|");
            
            
             while (true)
             {
                 Console.WriteLine("    _                                                                                _    \r\n  /\\| |/\\                                                                          /\\| |/\\ \r\n  \\ ` ' /   ______   ______   _ __ ___     ___   _ __    _   _   ______   ______   \\ ` ' / \r\n |_     _| |______| |______| | '_ ` _ \\   / _ \\ | '_ \\  | | | | |______| |______| |_     _|\r\n  / , . \\                    | | | | | | |  __/ | | | | | |_| |                    / , . \\ \r\n  \\/|_|\\/                    |_| |_| |_|  \\___| |_| |_|  \\__,_|                    \\/|_|\\/ ");

                 Console.WriteLine(" ");
                 Console.WriteLine(" ");
                 Console.WriteLine("  ______   ______   ______   ______   ______   ______   ______   ______   ______   ______ \r\n |______| |______| |______| |______| |______| |______| |______| |______| |______| |______|\r\n                                                                                          ");
                 Console.WriteLine("1.- Administrar mesa");
                 Console.WriteLine("2.- Agregar producto mesa");
                 Console.WriteLine("3.- Editar producto mesa");
                 Console.WriteLine("4.- Imprimir factura ");
                 Console.WriteLine("5.- Buscar productos ");
                 Console.WriteLine("6.- Imprimir menu");
                 Console.WriteLine("7.- Editar menu");
                 Console.WriteLine("8.- Cargar facturas");
                 int opcion = Convert.ToInt32(Console.ReadLine());
                 switch (opcion)
                 {
                     case 1:
                         administracion.AdministrarMesa();
                         break;
                     case 2:
                         AgregarProductoMesa();
                         break;
                     case 3:
                         EditarProductoMesa();
                         break;
                     case 4:
                         ImprimirFactura();
                         break;
                     case 5:
                         BuscarProductos();
                         break;
                     case 6:
                         ImprimirMenu();
                         break;
                     case 7:
                         carta.editarMenu();
                         break;
                     case 8:
                         guardarFacturas();
                         break;
                     default:
                         Console.WriteLine("error por favor poner un numero ");
                         break;
                 }
             }
            
            
        }
       
        static void  AgregarProductoMesa() 
        {
            Console.WriteLine("agregar producto mesa");
        }
        static void EditarProductoMesa() 
        { 
            Console.WriteLine("Editar producto mesa");
        }
        static void ImprimirFactura()
        {
            Console.WriteLine("imprimir factura");
        }
        static void BuscarProductos() 
        {
            Console.WriteLine("buscar productos");
        }
        static void ImprimirMenu()
        {
            Console.WriteLine("imprimir menu");
        }
        
        static void guardarFacturas() 
        {
            Console.WriteLine("guardar factura");
        }
    }
}
