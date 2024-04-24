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
                Console.WriteLine($"No existen productos en la mesa {numeroMesa}.");
                return;
            }


            List<Producto> productosConsumidos = _productosConsumidosPorMesa[numeroMesa];


            //ASCII 
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\r\n                                                                                \r\n          ____                                                                  \r\n        ,'  , `.                      ,--,                                      \r\n     ,-+-,.' _ |                    ,--.'|                                      \r\n  ,-+-. ;   , ||             __  ,-.|  | :      ,---.        ,---,              \r\n ,--.'|'   |  ;|           ,' ,'/ /|:  : '     '   ,'\\   ,-+-. /  |  .--.--.    \r\n|   |  ,', |  ':  ,--.--.  '  | |' ||  ' |    /   /   | ,--.'|'   | /  /    '   \r\n|   | /  | |  || /       \\ |  |   ,''  | |   .   ; ,. :|   |  ,\"' ||  :  /`./   \r\n'   | :  | :  |,.--.  .-. |'  :  /  |  | :   '   | |: :|   | /  | ||  :  ;_     \r\n;   . |  ; |--'  \\__\\/: . .|  | '   '  : |__ '   | .; :|   | |  | | \\  \\    `.  \r\n|   : |  | ,     ,\" .--.; |;  : |   |  | '.'||   :    ||   | |  |/   `----.   \\ \r\n|   : '  |/     /  /  ,.  ||  , ;   ;  :    ; \\   \\  / |   | |--'   /  /`--'  / \r\n;   | |`-'     ;  :   .'   \\---'    |  ,   /   `----'  |   |/      '--'.     /  \r\n|   ;/         |  ,     .-./         ---`-'            '---'         `--'---'   \r\n'---'           `--`---'                                                        \r\n                                                                                \r\n");
            Console.ResetColor();
            Console.WriteLine("  +---------------------------------------------------------------------------+");




            Console.WriteLine(" Marlon's.Corporation ");
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
            string path = @"C:\PC\POO\Proyecto#2_/MarlonRodriguezC/taller2-main"; //Esta es la ruta donde queremos que se guarde el archivo .txt
            string fileName = $"Factura_Mesa_{numeroMesa}.txt"; //Para guardar la factura ordenadamente
            string fullPath = Path.Combine(path, fileName);

            using (StreamWriter sw = File.CreateText(fullPath))
            {
                sw.WriteLine("FACTURA");
                sw.WriteLine("----------------------------------");
                sw.WriteLine($"Fecha: {DateTime.Now.ToShortDateString()}");
                sw.WriteLine($"Hora: {DateTime.Now.ToShortTimeString()}");
                sw.WriteLine("----------------------------------");
                sw.WriteLine($"Número de mesa: {numeroMesa}");
                sw.WriteLine("----------------------------------");
                sw.WriteLine("Productos consumidos: ");

                foreach (var producto in productos)
                {
                    sw.WriteLine($"- {producto.Nombre}: {producto.Precio:C}");
                }
                sw.WriteLine("----------------------------------");
                sw.WriteLine($"Total Productos Consumidos: {CalcularTotalProductos(productos):C}");
                sw.WriteLine($"IVA: {CalcularIVA(productos):C}");
                sw.WriteLine("----------------------------------");
                sw.WriteLine($"Total a Pagar: {CalcularIVA(productos) + CalcularTotalProductos(productos):C}"); //Suma total del IVA, más el total de los productos
                sw.WriteLine("----------------------------------");
            }

           
        }

    }

}
