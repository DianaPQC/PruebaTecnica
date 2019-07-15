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
    [Route("api/Libros")]
    [ApiController]
    public class tblLibrosController : ControllerBase
    {
        private readonly Context _context;

        public tblLibrosController(Context context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("GetAllLibros")]
        public IEnumerable<tblLibro> GetAllLibros()
        {

            return _context.tblLibro
                .Include(categ => categ.tblCategoria)
                .Include(auto => auto.tblAutor)
                .ToList();
        }
    }
}