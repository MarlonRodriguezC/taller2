using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___2
{
    public class Factura
    {

        private readonly Dictionary<byte, List<Producto>> _productosConsumidosPorMesa;

        public Factura(Dictionary<byte, List<Producto>> productosConsumidosPorMesa)
        {
            _productosConsumidosPorMesa = productosConsumidosPorMesa;
        }

        public void GenerarFactura(byte numeroMesa)
        {
            if (!_productosConsumidosPorMesa.ContainsKey(numeroMesa))
            {
                Console.WriteLine($" No se agregaron productos en la mesa {numeroMesa}.");
                Console.WriteLine($" intentalo nuevamente ");

                return;
            }


            List<Producto> productosConsumidos = _productosConsumidosPorMesa[numeroMesa];


            //ASCII Cambio de color 

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n __   __  __   __  _______  ______    _______  _______  __    _  _______      \r\n|  |_|  ||  | |  ||       ||    _ |  |       ||   _   ||  |  | ||       |     \r\n|       ||  | |  ||    ___||   | ||  |    ___||  |_|  ||   |_| ||   _   |     \r\n|       ||  |_|  ||   |___ |   |_||_ |   | __ |       ||       ||  | |  |     \r\n|       ||       ||    ___||    __  ||   ||  ||       ||  _    ||  |_|  |     \r\n| ||_|| ||       ||   |___ |   |  | ||   |_| ||   _   || | |   ||       |     \r\n|_|   |_||_______||_______||___|  |_||_______||__| |__||_|  |__||_______|     \r\n _______  _______  _______  _______  __   __  ______    _______  ___   ____   \r\n|       ||   _   ||       ||       ||  | |  ||    _ |  |   _   ||   | |    |  \r\n|    ___||  |_|  ||       ||_     _||  | |  ||   | ||  |  |_|  ||___| |_    | \r\n|   |___ |       ||       |  |   |  |  |_|  ||   |_||_ |       | ___    |   | \r\n|    ___||       ||      _|  |   |  |       ||    __  ||       ||   |   |   | \r\n|   |    |   _   ||     |_   |   |  |       ||   |  | ||   _   ||___|  _|   | \r\n|___|    |__| |__||_______|  |___|  |_______||___|  |_||__| |__|      |____|  \r\n");
            Console.ResetColor();
            Console.WriteLine("+----------------------------------------------------------------------------+");




            Console.WriteLine(" Muergano.Inc ");
            Console.WriteLine($"Fecha: {DateTime.Now.ToShortDateString()}");
            Console.WriteLine($"Hora: {DateTime.Now.ToShortTimeString()}");
            Console.WriteLine($"----------------------------------");
            Console.WriteLine($"Número de mesa: {numeroMesa}"); //El número que identifica cada mesa para generar su respectiva factura
            Console.WriteLine($"----------------------------------");
            Console.WriteLine("Productos consumidos:");

            foreach (var producto in productosConsumidos)
            {
                Console.WriteLine($"- {producto.Nombre}: {producto.Precio:C}");
            }
            Console.WriteLine($"----------------------------------");
            Console.WriteLine($"Total Productos Consumidos: {CalcularTotalProductos(productosConsumidos):C}");
            Console.WriteLine($"IVA: {CalcularIVA(productosConsumidos):C}");
            Console.WriteLine($"----------------------------------");
            Console.WriteLine($"Total a Pagar: {CalcularIVA(productosConsumidos) + CalcularTotalProductos(productosConsumidos):C}");
            Console.WriteLine($"----------------------------------");
            Console.WriteLine("Gracias por tu Compra ! Te esperamos pronto ¡");


            ExportarFacturaATXT(numeroMesa, productosConsumidos);




        }

        private float CalcularTotalProductos(List<Producto> productos) //Esta función suma los precios de los productos 
        {
            return productos.Sum(producto => producto.Precio);
        }

        private float CalcularIVA(List<Producto> productos) 
        {
            float totalProductos = CalcularTotalProductos(productos); //Calculamos el IVA del total de los productos
            return totalProductos * 0.19f; // IVA del 19%
        }


        private void ExportarFacturaATXT(byte numeroMesa, List<Producto> productos) //La función para Exportar la factura de consola a un archivo .txt
        {
            //Ruta de la carpeta donde se guardas las facturas en formato txt
            string path = @"C:\Users\ricar\OneDrive\Documentos\Facturas"; 
            string fileName = $"Factura de la mesa #{numeroMesa}.txt"; //Para guardar la factura con el numero de mesa
            string fullPath = Path.Combine(path, fileName);

            using (StreamWriter sw = File.CreateText(fullPath))
            {
                sw.WriteLine("FACTURA");
                sw.WriteLine("------------------------------------------");
                sw.WriteLine($"Fecha: {DateTime.Now.ToShortDateString()}");
                sw.WriteLine($"Hora: {DateTime.Now.ToShortTimeString()}");
                sw.WriteLine("------------------------------------------");
                sw.WriteLine($"Número de mesa: {numeroMesa}");
                sw.WriteLine("------------------------------------------");
                sw.WriteLine("Productos consumidos : ");

                foreach (var producto in productos)
                {
                    sw.WriteLine($"- {producto.Nombre}: {producto.Precio:C}");
                }
                sw.WriteLine("----------------------------------");
                sw.WriteLine($" TOTAL : {CalcularTotalProductos(productos):C}");
                sw.WriteLine($"IVA: {CalcularIVA(productos):C}");
                sw.WriteLine("----------------------------------");
                sw.WriteLine($"Total a Pagar: {CalcularIVA(productos) + CalcularTotalProductos(productos):C}"); //Suma total del IVA, más el total de los productos
                sw.WriteLine("----------------------------------");
            }


        }

    }

}
