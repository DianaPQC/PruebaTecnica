using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Configuration;

namespace ServiciosBiblioteca.Models
{
    public class tblAutor
    {
        /*Modelo tabla tblAutor*/
        [Key]
        public int? idAutor { get; set; }

        [Required]
        [StringLength(150)]
        public string nombres { get; set; }

        [Required]
        [StringLength(150)]
        public string apellidos { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime fechaNacimiento { get; set; }

    }
}
