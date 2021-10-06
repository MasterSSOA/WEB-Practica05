using System;
using System.Collections.Generic;

namespace Practica05.Core
{
    public static class Helpers
    {
        //Métodos.
        public static void Display(this IEnumerable<Producto> productos)
        {
            //Encabezado.
            Console.WriteLine("|ID\t| Nombre\t| Categoria\t| Marca\t| Módelo\t| Precio\t|");

            //Cuerpo.
            foreach (var producto in productos)
            {
                Console.WriteLine
                    (
                    $"|{producto.id}\t| " +
                    $"{producto.nombre}\t| " +
                    $"{producto.categoriaId}\t| " +
                    $"{producto.marca}\t| " +
                    $"{producto.modelo}\t| " +
                    $"{string.Format("{0:0,0.00}", producto.precio)}\t|"
                    );
            }
        }
    } 
}
