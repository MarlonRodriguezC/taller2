using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller2
{
    internal class Administracion
    {
        Program programa = new Program();
        private int numeroDeMesasDefecto = 5;
        public int NumeroDeMesasDefecto { get => numeroDeMesasDefecto; set => numeroDeMesasDefecto = value; }
        public void AdministrarMesa()
        {
           
            while(true)
            {
                Console.WriteLine("1. -Elegir mesa");

                Console.WriteLine("aqui se supone que aparecen las mesas");

                int opcion2 = Convert.ToInt32(Console.ReadLine());
                switch (opcion2)
                {
                    case 1:
                        Console.WriteLine("se va a elegir mesa");
                        int opcion3 = Convert.ToInt32(Console.ReadLine());
                        switch (opcion3)
                        {
                            case 1:
                                Console.WriteLine("1.-Ver productos en la mesa");
                  
                                break;
                            case 2:
                                Console.WriteLine("2.-Agregar productos");

                               
                                break;
                            case 3: 
                                Console.WriteLine("3.-Eliminar productos");
                                break;
                            default:
                                Console.WriteLine("error por favor poner un numero");
                                break;
                        }
                        break;
                    case 2:
                     
                        break;
                    default:
                        Console.WriteLine("error por favor poner un numero ");
                        break;
                }

            }
           
           
        }
    }
}
