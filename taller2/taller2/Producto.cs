using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller2
{
    internal class Producto
    {

        // este objeto lo cree con el proposito que ricardo lo tomase
        
        public string nombreProducto;
       
        private float precio;
       
        private float impuesto;

        private float precioTotal;

        private float id;




        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public float Precio { get => precio; set => precio = value; }
  
        public float Impuesto { get => impuesto; set => impuesto = value; }
        public float PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public float Id { get => id; set => id = value; }
        

        public Producto(string nombreProducto, float precio )
        {
            NombreProducto = nombreProducto;
            Precio = precio;
                
        }
    }
}
