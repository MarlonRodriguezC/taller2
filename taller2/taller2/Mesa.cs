using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller2
{
    internal class Mesa 
    {
        public int NumeroDeMesa;
        public bool Ocupada;
        public List<Producto> productos;

        public Mesa(int numero) 
        {
            NumeroDeMesa = numero;
            Ocupada = false;
            productos = new List<Producto>();
            //productos.Add(new Producto("Pita siciliana", 100));
        }
        public void Ocupar()
        {
            this.Ocupada = true;
        }

        public void DesocuparMesa()
        {
            Ocupada = false;
            productos.Clear();
        }

        public List<Producto> getproductos() { 
            return productos;
        }
    }
}
