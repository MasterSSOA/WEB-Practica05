using System;
using System.Linq;
using Practica05.Core;
using System.Collections.Generic;

namespace Practica05.Repository
{
    public class ProductoEnMemoria : IRepositorioProducto
    {
        //Propiedades.
        List<Producto> productos;
        List<Categoria> categorias;

        //Constructor.
        public ProductoEnMemoria()
        {
            //Cargando productos.
            productos = new List<Producto>()
            {
                new Producto()
                {
                    id = 1,
                    categoriaId = 5,
                    nombre = "Android ",
                    marca = "Samsung",
                    modelo = "A20   ",
                    precio = 4300
                },
                new Producto()
                {
                    id = 2,
                    categoriaId = 5,
                    nombre = "IPhone ",
                    marca = "Apple  ",
                    modelo = "Xs    ",
                    precio = 17500
                },new Producto()
                {
                    id = 3,
                    categoriaId = 5,
                    nombre = "Celular",
                    marca = "Samsung",
                    modelo = "A30   ",
                    precio = 9800
                },new Producto()
                {
                    id = 4,
                    categoriaId = 1,
                    nombre = "Smart Watch",
                    marca = "Apple  ",
                    modelo = "Serie 7",
                    precio = 12300
                },new Producto()
                {
                    id = 5,
                    categoriaId = 3,
                    nombre = "Tenis  ",
                    marca = "Jordan",
                    modelo = "X",
                    precio = 14300
                },new Producto()
                {
                    id = 6,
                    categoriaId = 1,
                    nombre = "Reloj Digital",
                    marca = "Casio  ",
                    modelo = "3298   ",
                    precio = 4800
                },new Producto()
                {
                    id = 7,
                    categoriaId = 3,
                    nombre = "Tenis ",
                    marca = "Nike  ",
                    modelo = "Air Force 1",
                    precio = 5000
                },new Producto()
                {
                    id = 8,
                    categoriaId = 2,
                    nombre = "Laptop",
                    marca = "Apple  ",
                    modelo = "Macbook Pro 2022",
                    precio = 130000
                },new Producto()
                {
                    id = 9,
                    categoriaId = 4,
                    nombre = "Smart TV",
                    marca = "Samsung",
                    modelo = "Serie 10",
                    precio = 48000
                },new Producto()
                {
                    id = 10,
                    categoriaId = 2,
                    nombre = "Laptop",
                    marca = "Asus  ",
                    modelo = "Rog x2045",
                    precio = 85320
                }
            };

            //Cargando categorias.
            categorias = new List<Categoria>()
            {
                new Categoria(){id = 1, nombre = "Reloj   "},
                new Categoria(){id = 2, nombre = "Portatil"},
                new Categoria(){id = 3, nombre = "Calzado"},
                new Categoria(){id = 4, nombre = "Televisor"},
                new Categoria(){id = 5, nombre = "SmartPhone"},
                new Categoria(){id = 6, nombre = "Belleza"},
                new Categoria(){id = 7, nombre = "Hogar   "}
            };
        }

        //Metodos.
        //Ejercicio 1 - Productos por una categoría en específico.
        public IEnumerable<Producto> GetProductosPorCategoria(int CategoriaId) =>
             from producto in productos
             where producto.categoriaId.Equals(CategoriaId)
             select producto;

        //Ejercicio 2 - Productos entre 3,000 - 5,000.
        public IEnumerable<Producto> GetProductosIntervalo(double Inicial, double Final) =>
            from producto in productos
            where Inicial <= producto.precio && producto.precio <= Final
            orderby producto.precio descending
            select producto;

        //Ejercicio 3 - Nombres de las categorías de los productos registrados.
        public IEnumerable<string> GetCategoriasRegistradas() =>
            (from producto in productos 
            join categoria in categorias on producto.categoriaId equals categoria.id
            select categoria.nombre).Distinct();
    }
}
