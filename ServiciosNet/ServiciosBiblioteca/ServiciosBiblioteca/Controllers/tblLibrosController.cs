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
        public IEnumerable<tblLibro> GetPlayer()
        {
            return _context.tblLibro.ToList();
        }
    }
}