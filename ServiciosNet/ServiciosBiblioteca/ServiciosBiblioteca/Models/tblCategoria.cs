using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ServiciosBiblioteca.Models
{
    //[Table("tblCategoria", Schema ="dbo")]
    
    public class tblCategoria
    {
        [Key]
        public int? idCategoria { get; set; }

        [Required]
        [StringLength(150)]
        public string nombre { get; set; }

        [Required]
        [StringLength(250)]
        public string descripcion { get; set; }
    }
}
