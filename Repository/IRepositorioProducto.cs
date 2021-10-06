using System;
using Practica05.Core;
using System.Collections.Generic;

namespace Practica05.Repository
{
    public interface IRepositorioProducto
    {
        IEnumerable<Producto> GetProductosPorCategoria(int CategoriaId);
        IEnumerable<Producto> GetProductosIntervalo(double Inicial, double Final);
        IEnumerable<string> GetCategoriasRegistradas();
    }
}
