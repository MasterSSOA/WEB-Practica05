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
            Console.WriteLine("|ID\t| Nombre\t\t| Categoria\t| Marca\t\t| Módelo\t| Precio\t|");

            //Cuerpo.
            foreach (var producto in productos)
            {
                Console.WriteLine
                    (
                        $"|{producto.id.ToString("00")}\t| " +
                        $"{producto.nombre}\t\t| " +
                        $"{producto.categoriaId.ToString("00")}\t\t| " +
                        $"{producto.marca}\t| " +
                        $"{producto.modelo}\t| " +
                        $"{string.Format("{0:0,0.00}", producto.precio)}\t|"
                    );
            }
        }
        public static void Display(this IEnumerable<string> categorias)
        {
            //Encabezado.
            Console.WriteLine("|Nombre\t\t|");

            //Cuerpo.
            foreach (var categoria in categorias)
            {
                Console.WriteLine($"|{categoria}\t| ");
            }
        }
        public static void Division(int n)
        {
            string line = string.Empty;
            for (int i = 0; i < n; i++)
                line += "_____";
            Console.WriteLine($"{line}\n");
        }
    } 
}
