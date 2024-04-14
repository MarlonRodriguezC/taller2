using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller2
{
    internal class AdministrarStock
    {
       // Producto producto = new Producto("nombre del producto");
       // private Producto[] _productos;
       // private int _limite = 10;
       // private int _numerodeProductos;
       //
       //
       //
       // public int Limite { get => _limite; set => _limite = value; }
       // public int NumerodeProductos { get => _numerodeProductos; set => _numerodeProductos = value; }
       // public void Stock(int limite)
       // {
       //     this._productos = new Producto[limite];
       //     _limite = limite;
       //     NumerodeProductos = 0;
       // }
       // public void OpcionesInventario()
       // {
       //     Console.WriteLine("Por favor elegir una opcion");
       //     Console.WriteLine("----------------------------");
       //     Console.WriteLine("1.-agregar productos  2.-quitar productos");
       //     int opcion7 = Convert.ToInt32(Console.ReadLine());
       //     switch (opcion7)
       //     {
       //         case 1:
       //             AgregarProductos("pizza",10);
       //
       //             break;
       //         case 2:
       //             //QuitarProductos();
       //             break;
       //         case 3:
       //              VerProductos();
       //
       //             break;
       //
       //         default:
       //             Console.WriteLine("error por favor poner un numero");
       //             break;
       //     }
       // }
       //
       //
       //
       //
       // public void AgregarProductos(string nombreProducto , int cantidad)
       // {
       //     
       //     if (_numerodeProductos + cantidad <= _limite)
       //     {
       //         for (int i = _numerodeProductos; i < _numerodeProductos + cantidad; i++)
       //         {
       //             _productos[i] = new Producto(nombreProducto);
       //             NumerodeProductos++;
       //             Console.WriteLine("se agregaron productos");
       //
       //         }
       //             
       //
       //     }
       //     else { Console.WriteLine("stock lleno"); }
       //
       // }


        //public void QuitarProductos(Producto p)
        //{
        //
        //    int posicion = -1;
        //    if (p! == null && NumerodeProductos != 0 )
        //    {
        //        for (int i = 0; i < _productos.GetLength(0); i++)
        //        {
        //            if (p.Id == _productos[i].Id)
        //            {
        //                posicion = i;
        //            }
        //        }
        //    }
        //    if (posicion == -1)
        //    {
        //        Console.WriteLine("NO EXISTE EL PRODUCTO");
        //    }
        //    else
        //    {
        //        _productos[posicion] = null;
        //        for (int i = posicion;i < _productos.GetLength(0);i++)
        //        {
        //     
        //        }
        //    }
        //    Console.WriteLine("aqui se quitan productos");
        //}




       // public void VerProductos()
       // {
       //     Console.WriteLine("aqui puede ver los productos en stock"); 
       //     for (int i = 0; i < _numerodeProductos; i++)
       //     {
       //         Console.WriteLine(_productos[i].ToString());
       //     }
       //     
       // }
    }
}
