using System;
namespace Practica05.Core
{
    public class Producto
    {
        //Propiedades.
        public int id { get; set; }
        public string nombre { get; set; }
        public int categoriaId { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public double precio { get; set; }
    }
}
