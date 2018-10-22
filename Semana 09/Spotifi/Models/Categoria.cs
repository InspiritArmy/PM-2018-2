
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Spotifi.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public List<Banda> Bandas { get; set; }
    }
}