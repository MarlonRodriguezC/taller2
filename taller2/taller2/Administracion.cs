using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller2
{
    internal class Administracion
    {
        
        public void ver_estado_mesas(Mesa[] mesas)
        {
            Console.WriteLine("* Estado de las mesas desde administrador:");
            for (int i = 0; i < mesas.Length; i++)
            {
                Console.WriteLine($"Mesa {mesas[i].NumeroDeMesa}: {(mesas[i].Ocupada ? "Ocupada" : "Disponible")}");
            }
        }

        public Mesa[] ocupar_mesa(Mesa[] mesas)
        {
            Console.WriteLine("* Ingrese el número de mesa que desea ocupar:");
            int numeroMesa;
            if (int.TryParse(Console.ReadLine(), out numeroMesa))
            {
                if (numeroMesa >= 1 && numeroMesa <= mesas.Length)
                {
                    if (!mesas[numeroMesa - 1].Ocupada)
                    {
                        mesas[numeroMesa - 1].Ocupar();
                        Console.WriteLine($"Mesa {numeroMesa} ocupada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine($"La mesa {numeroMesa} ya está ocupada.");
                    }
                }
                else
                {
                    Console.WriteLine("Número de mesa inválido.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, introduzca un número de mesa válido.");
            }
            return mesas;
        }

        public Mesa[] desocupar_mesa(Mesa[] mesas)
        {
            Console.WriteLine("* Ingrese el número de mesa que desea desocupar:");
            if (int.TryParse(Console.ReadLine(), out int numeroMesa))
            {
                if (numeroMesa >= 1 && numeroMesa <= mesas.Length)
                {
                    if (mesas[numeroMesa - 1].Ocupada)
                    {
                        mesas[numeroMesa - 1].DesocuparMesa();
                        Console.WriteLine($"Mesa {numeroMesa} desocupada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine($"La mesa {numeroMesa} ya está desocupada.");
                    }
                }
                else
                {
                    Console.WriteLine("Número de mesa inválido.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, introduzca un número de mesa válido.");
            }
            return mesas;
        }
        public void ver_productos_mesa(Mesa[] mesas)
        {

            Console.WriteLine("* Ingrese el numero de la mesa para ver productos:");
            if (int.TryParse(Console.ReadLine(), out int numeroMesa))
            {
                if (numeroMesa >= 1 && numeroMesa <= mesas.Length)
                {
                    List<Producto> productos= mesas[numeroMesa-1].getproductos();
                    foreach (var producto in productos)
                    {
                        Console.WriteLine(producto.nombreProducto);
                    }
                }
                else
                {
                    Console.WriteLine("Número de mesa inválido.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, introduzca un número de mesa válido.");
            }

            
        }
        

    }

}
