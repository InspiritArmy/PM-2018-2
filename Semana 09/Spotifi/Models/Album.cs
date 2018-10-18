namespace Spotifi.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Banda Banda { get; set; }
        public int BandaId { get; set; }
    }
}