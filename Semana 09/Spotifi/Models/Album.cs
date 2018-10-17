namespace Spotifi.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public GrupoMusical Banda { get; set; }
    }
}