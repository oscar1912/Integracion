using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Entidades;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly AplicationDbContex _contex;

        public CategoriaController(AplicationDbContex contex)
        {
            _contex = contex;
        }
        [HttpGet]
        public async Task<ActionResult<List<Categoria>>> GetCategorias()
        {
            List<Categoria> lista = await _contex.Categorias.ToListAsync();
            return Ok(lista);
        }
    }
}