using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.Entidades;

namespace Data
{
    public class AplicationDbContex : DbContext
    {
        public AplicationDbContex(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Categoria>Categorias { get; set; }
    }
}