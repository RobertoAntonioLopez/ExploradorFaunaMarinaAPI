namespace ExploradorFaunaMarinaAPI.Models
{
    public class EspecieMarina
    {
        public int Id { get; set; }
        public string NombreComun { get; set; }
        public string NombreCientifico { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public string Habitat { get; set; }
    }
}