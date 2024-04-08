using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller2
{
    internal class Factura
    {
        private string fecha;
        //private int estado_actual;
        private string medio_pago;
        private float iva;
        private float total;
        private Producto[] canasta;
        //private int indice;
        private int numero_factura;

        public string Fecha { get => fecha; set => fecha = value; }
        public string Medio_pago { get => medio_pago; set => medio_pago = value; }
        public float Iva { get => iva; set => iva = value; }
        public float Total { get => total; set => total = value; }
        public int Numero_factura { get => numero_factura; set => numero_factura = value; }
        internal Producto[] Canasta { get => canasta; set => canasta = value; }
    }
}
