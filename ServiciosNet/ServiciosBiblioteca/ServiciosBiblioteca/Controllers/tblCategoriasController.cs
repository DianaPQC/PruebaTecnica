using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiciosBiblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        [Route("GetAllCategorias")]
        public IEnumerable<tblCategoria> GetAllCategorias()
        {
            return _context.tblCategoria.ToList();
        }

        // GET: UserTbs
        public async Task<IActionResult> Index()
        {
            return NotFound(); 
        }

        [HttpPost]
        [Route("AddCategoria")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCategoria([Bind("nombre,descripcion")] tblCategoria categoria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return BadRequest(ModelState);
        }
    }

    
}
    
