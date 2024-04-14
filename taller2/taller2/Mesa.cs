using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace taller2
{
    internal class Mesa 
    {
        public int NumeroDeMesa;
        public bool Ocupada;
        public List<Producto> productos; //lista de productos, la cree para ricardo si la quiere 
        // usar , abajo hay un comentario de pita siciliana donde se puede ver la idea de lo de los 
        // productos aunque 
        
        public Mesa(int numero) 
        {
            NumeroDeMesa = numero;
            Ocupada = false;
            productos = new List<Producto>();
            //productos.Add(new Producto("Pita siciliana", 100));
        }
        //funcion usadas en los returns para ocupar la mesa
        public void Ocupar()
        {
            this.Ocupada = true;
        }
        //funcion usadas en los returns para desocupar la mesa
        public void DesocuparMesa()
        {
            Ocupada = false;
            productos.Clear();
        }
        //funcion usada para tomar los productos en mesa, repito parte adelantada por marlon
        // ya si ricardo la borra es cosa de el 
        public List<Producto> getproductos() { 
            return productos;
        }
    }
}
