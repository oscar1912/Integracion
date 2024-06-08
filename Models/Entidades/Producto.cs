using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public String NombreProducto { get; set; }
        public String Categoria { get; set; }
        public String Marca { get; set; }
        public Double Precio { get; set; }
    }
}