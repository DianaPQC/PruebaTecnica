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
    [Route("api/Autores")]
    [ApiController]
    public class tblAutoresController : ControllerBase
    {

        private readonly Context _context;

        public tblAutoresController(Context context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<tblAutor> GetPlayer()
        {
            return _context.tblAutor.ToList();
        }
    }
}