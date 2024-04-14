using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller2
{
    internal class AdministrarFacturas
    {
        public void OpcionesFacturas()
        {
            Console.WriteLine("Por favor elegir una opcion");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1.-Imprimir factura  2.-Ver facturas pasadas");
            int opcion6 = Convert.ToInt32(Console.ReadLine());
            switch (opcion6)
            {
                case 1:
                    ImprimirFactura();

                    break;
                case 2:
                    VerFacturasPasadas();


                    break;

                default:
                    Console.WriteLine("error por favor poner un numero");
                    break;
            }
        }
        public void ImprimirFactura()
        {
            Console.WriteLine(" Imprimir Factura");

        }
        public void VerFacturasPasadas()
        {
            Console.WriteLine("ver facturas pasadas");
        }
    }
}
