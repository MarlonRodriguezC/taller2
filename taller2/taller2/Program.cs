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
        static void iniciar_mesas()
        {
            mesas = new Mesa[5];
            for (int i = 0; i < mesas.Length; i++)
            {
                mesas[i] = new Mesa(i+1);
                //Console.Write(mesas[i].NumeroDeMesa);
                //Console.Write(mesas[i].Ocupada);
                //Console.WriteLine("---------------");
            }
        }


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

           // static void VerEstadoMesas()
           // {
           //     Console.WriteLine("Estado de las mesas:");
           //     foreach (var mesa in mesas)
           //     {
           //         Console.WriteLine($"Mesa {mesa.NumeroDeMesa}: {(mesa.Ocupada ? "Ocupada" : "Disponible")}");
           //     }
           //
           // }
           //
           // static void OcuparMesa()
           // {
           //     Console.WriteLine("Ingrese el número de mesa que desea ocupar:");
           //     if (int.TryParse(Console.ReadLine(), out int numeroMesa))
           //     {
           //         if (numeroMesa >= 1 && numeroMesa <= mesas.Length)
           //         {
           //             if (!mesas[numeroMesa - 1].Ocupada)
           //             {
           //                 mesas[numeroMesa - 1].OcuparMesa();
           //                 Console.WriteLine($"Mesa {numeroMesa} ocupada correctamente.");
           //
           //
           //
           //
           //
           //             }
           //             else
           //             {
           //                 Console.WriteLine($"La mesa {numeroMesa} ya está ocupada.");
           //             }
           //
           //         }
           //         else
           //         {
           //             Console.WriteLine("Número de mesa inválido.");
           //         }
           //     }
           //     else
           //     {
           //         Console.WriteLine("Entrada inválida. Por favor, introduzca un número de mesa válido.");
           //     }
           // }

            //static void DesocuparMesa()
            //{
            //    Console.WriteLine("Ingrese el número de mesa que desea desocupar:");
            //    if (int.TryParse(Console.ReadLine(), out int numeroMesa))
            //    {
            //        if (numeroMesa >= 1 && numeroMesa <= mesas.Length)
            //        {
            //            if (mesas[numeroMesa - 1].Ocupada)
            //            {
            //                mesas[numeroMesa - 1].DesocuparMesa();
            //                Console.WriteLine($"Mesa {numeroMesa} desocupada correctamente.");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"La mesa {numeroMesa} ya está desocupada.");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Número de mesa inválido.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Entrada inválida. Por favor, introduzca un número de mesa válido.");
            //    }
            //}

            


        
    }
   
}

