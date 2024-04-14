using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller2
{
    internal class AdministracionCarta
    {
        Program programa = new Program();
        private string nombreProducto;
        //private int tamano;
        private float precioTotal;
        //private float peso;
        private int cantidad;


        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public void OpcionesMenu()
        {
            Console.WriteLine("Por favor elegir una opcion");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1.-editar menu  2.-imprimir menu");
            int opcion4 = Convert.ToInt32(Console.ReadLine());
            switch (opcion4)
            {
                case 1:
                    editarMenu();

                    break;
                case 2:
                    ImprimirMenu();


                    break;
              
                default:
                    Console.WriteLine("error por favor poner un numero");
                    break;
            }
        }
        public void editarMenu()
        {
            Console.WriteLine("editaste menu");
         
        }
        public void ImprimirMenu()
        {
            Console.WriteLine("imprimir menu");
        }
    }
}
