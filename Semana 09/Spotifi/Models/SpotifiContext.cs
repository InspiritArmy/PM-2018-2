using Microsoft.EntityFrameworkCore;

namespace Spotifi.Models
{
    public class SpotifiContext : DbContext
    {
        public SpotifiContext(DbContextOptions<SpotifiContext> options) 
        : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Banda>().HasData(
                new Banda {
                    Id = 1,
                    Nombre = "Link in Park",
                    Foto = "https://i.kym-cdn.com/photos/images/newsfeed/000/937/730/e9a.jpg"
                },
                new Banda {
                    Id = 2,
                    Nombre = "BTS",
                    Foto = "https://multimedia.larepublica.pe/720x405/larepublica/imagen/2018/10/16/noticia-peli-bts-burn-stage.jpg"
                }
            );
        }

        public DbSet<Banda> Bandas { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Album> Albumes { get; set; }
    }
}