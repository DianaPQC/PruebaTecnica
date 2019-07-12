using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Configuration;


namespace ServiciosBiblioteca.Models
{
    public class tblLibro
    {
        [Key]
        public int? idLibro { get; set; }

        [Required]
        [StringLength(250)]
        public string nombre { get; set; }

        [Required]
        public int idAutor { get; set; }

        [Required]
        public int idCategoria { get; set; }
    }
}
