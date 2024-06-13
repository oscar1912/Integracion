using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Dtos
{
    public class ProductoDto
    {
       public String NombreProducto { get; set; }
        public String Categoria { get; set; }
        public String Marca { get; set; }
        public decimal Precio { get; set; } 
        public decimal Costo { get; set; }
    }
}