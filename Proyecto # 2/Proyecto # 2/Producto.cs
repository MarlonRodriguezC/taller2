﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___2
{
    public class Producto
    {
        private string nombre;
        private int id;
        private float precio;
        //Cada producto se va identificar por un ID



        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public float Precio { get => precio; set => precio = value; }


        public Producto()
        {

        }



        public Producto(string nombre, float precio, int id)
        {
            this.nombre = nombre;
            this.id = id;
            this.precio = precio;
        }
    }
}
