using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller2
{
    internal class Carta
    {
        private string nombreProducto;
        //private int tamano;
        private float precioTotal;
        //private float peso;
        private int cantidad;


        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float PrecioTotal { get => precioTotal; set => precioTotal = value; }

        public void editarMenu()
        {
            Console.WriteLine("editaste menu");
         
        }
    }
}
