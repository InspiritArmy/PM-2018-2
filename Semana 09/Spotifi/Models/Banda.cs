
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Spotifi.Models
{
    public class Banda
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public List<Album> Albumes { get; set; }
    }
}