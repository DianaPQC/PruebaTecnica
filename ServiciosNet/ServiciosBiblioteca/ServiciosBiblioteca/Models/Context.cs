using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ServiciosBiblioteca.Models
{
    public class Context : DbContext
    {
        /*Contexto de la base de datos.*/
        private readonly string connectionString;
        
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<tblCategoria> tblCategoria { get; set; }
        public DbSet<tblAutor> tblAutor { get; set; }
        public DbSet<tblLibro> tblLibro { get; set; }
    }
}
