using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace taller2
{
    internal class Program
    {
        static Mesa[] mesas;
        static Producto[] inventario;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("$$\\       $$\\                                                   $$\\       $$\\           \r\n$$ |      \\__|                                                  \\__|      $$ |          \r\n$$$$$$$\\  $$\\  $$$$$$\\  $$$$$$$\\ $$\\    $$\\  $$$$$$\\  $$$$$$$\\  $$\\  $$$$$$$ | $$$$$$\\  \r\n$$  __$$\\ $$ |$$  __$$\\ $$  __$$\\\\$$\\  $$  |$$  __$$\\ $$  __$$\\ $$ |$$  __$$ |$$  __$$\\ \r\n$$ |  $$ |$$ |$$$$$$$$ |$$ |  $$ |\\$$\\$$  / $$$$$$$$ |$$ |  $$ |$$ |$$ /  $$ |$$ /  $$ |\r\n$$ |  $$ |$$ |$$   ____|$$ |  $$ | \\$$$  /  $$   ____|$$ |  $$ |$$ |$$ |  $$ |$$ |  $$ |\r\n$$$$$$$  |$$ |\\$$$$$$$\\ $$ |  $$ |  \\$  /   \\$$$$$$$\\ $$ |  $$ |$$ |\\$$$$$$$ |\\$$$$$$  |\r\n\\_______/ \\__| \\_______|\\__|  \\__|   \\_/     \\_______|\\__|  \\__|\\__| \\_______| \\______/ ");
            Console.ResetColor();
            iniciar_mesas();
            control();
        }
        // inicia las mesas, asi el programa puede ver cuantas mesas deben ser (son 5)
        static void iniciar_mesas()
        {
            mesas = new Mesa[5];
            for (int i = 0; i < mesas.Length; i++)
            {
                mesas[i] = new Mesa(i+1);
                
            }
        }

        // control es el menu principal de usuario aqui puede elegir mesa, administrar inventario ,
        // imprimir facturas y demas 
        static void control( )
        {
                bool en_ejecucion = true;
                while (en_ejecucion)
                {
                    Console.WriteLine("    _                                                                                _    \r\n  /\\| |/\\                                                                          /\\| |/\\ \r\n  \\ ` ' /   ______   ______   _ __ ___     ___   _ __    _   _   ______   ______   \\ ` ' / \r\n |_     _| |______| |______| | '_ ` _ \\   / _ \\ | '_ \\  | | | | |______| |______| |_     _|\r\n  / , . \\                    | | | | | | |  __/ | | | | | |_| |                    / , . \\ \r\n  \\/|_|\\/                    |_| |_| |_|  \\___| |_| |_|  \\__,_|                    \\/|_|\\/ ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  ______   ______   ______   ______   ______   ______   ______   ______   ______   ______ \r\n |______| |______| |______| |______| |______| |______| |______| |______| |______| |______|\r\n                                                                                          ");
                    Console.WriteLine("1.- Administrar mesa");
                    Console.WriteLine("2.- Administrar o crear facturas ");
                    Console.WriteLine("3.- Administrar Inventario ");
                    Console.WriteLine("4.- Menu del restaurante");
                    Console.WriteLine("5.- Salir");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {

                        case 1:
                            opcion_1();
                            break;
                        case 2:

                            break;
                        case 3:
                        
                            break;
                        case 4:

                            break;
                        case 5:
                            en_ejecucion = false;
                            break;
                        default:
                            Console.WriteLine("error, por favor poner un numero ");
                            break;
                    }
                    Console.WriteLine("  ______   ______   ______   ______   ______   ______   ______   ______   ______   ______ \r\n |______| |______| |______| |______| |______| |______| |______| |______| |______| |______|\r\n                                                                                          ");

            }
        }



        //la opcion 1 es la opcion de administrar mesas y la cual todos sus options te
        //va a llevar al documento "administracion"
        static void opcion_1() {
            bool en_ejecucion = true;
            Administracion admin_obj = new Administracion();
            while (en_ejecucion)
            {
                Console.WriteLine("------------------------***------------------------");
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Ver estado de las mesas");
                Console.WriteLine("2. Ocupar una mesa");
                Console.WriteLine("3. Desocupar una mesa");
                Console.WriteLine("4. Ver que productos tiene una mesa");
                Console.WriteLine("5. Salir");
                Console.WriteLine("------------------------***------------------------");

                int numero ;
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    switch (numero)
                    {
                        case 1:
                            admin_obj.ver_estado_mesas(mesas);
                            break;
                        case 2:
                            mesas=admin_obj.ocupar_mesa(mesas);
                            admin_obj.ver_estado_mesas(mesas);

                            break;
                        case 3:
                            mesas = admin_obj.desocupar_mesa(mesas);
                            admin_obj.ver_estado_mesas(mesas);
                            break;

                        case 4:
                            admin_obj.ver_productos_mesa(mesas);
                            break;
                        case 5:
                            en_ejecucion = false;
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, introduzca un número.");
                }
            }
        }

         


        
    }
   
}

