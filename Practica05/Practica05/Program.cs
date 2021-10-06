using System;
using Practica05.Core;
using Practica05.Repository;
using System.Collections.Generic;

namespace Practica05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Obtención de Productos.
            ProductoEnMemoria productoEnMemoria = new ProductoEnMemoria();

            //Ejercicio 1 - Productos por una categoría en específico.
            productoEnMemoria.GetProductosPorCategoria(1).Display();
            Helpers.Division(20);

            //Ejercicio 2 - Productos entre 3,000 - 5,000.
            productoEnMemoria.GetProductosIntervalo(3000, 5000).Display();
            Helpers.Division(20);

            //Ejercicio 3 - Nombres de las categorías de los productos registrados.
            productoEnMemoria.GetCategoriasRegistradas().Display();
        }
    }
}
