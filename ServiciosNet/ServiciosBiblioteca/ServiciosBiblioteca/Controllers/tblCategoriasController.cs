using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiciosBiblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ServiciosBiblioteca.Controllers
{

    [Route("api/Categorias")]
    [ApiController]
    public class tblCategoriasController : ControllerBase
    {


        private readonly Context _context;
        public tblCategoriasController(Context context)
        {
            _context = context;
        }

 
        [HttpGet]
        public IEnumerable<tblCategoria> GetPlayer()
        {
            return _context.tblCategoria.ToList();
        }
    }
    
}