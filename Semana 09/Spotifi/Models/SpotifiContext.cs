using Microsoft.EntityFrameworkCore;

namespace Spotifi.Models
{
    public class SpotifiContext : DbContext
    {
        public SpotifiContext(DbContextOptions<SpotifiContext> options) 
        : base(options) {

        }

        public DbSet<GrupoMusical> Bandas { get; set; }
        public DbSet<Album> Albumes { get; set; }
    }
}