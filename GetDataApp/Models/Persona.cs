using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetDataApp.Models
{
    public class Persona
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
