using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller2
{
    internal class Producto
    {
        private string nombreProducto;
       
        private float precio;
       
        private float impuesto;

        private float precioTotal;


        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public float Precio { get => precio; set => precio = value; }
  
        public float Impuesto { get => impuesto; set => impuesto = value; }
        public float PrecioTotal { get => precioTotal; set => precioTotal = value; }
    }
}
