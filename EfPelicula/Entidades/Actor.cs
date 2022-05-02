using System.ComponentModel.DataAnnotations;

namespace EfPelicula.Entidades
{
    public class Actor
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Biografia { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public HashSet<PeliculaActor> PeliculaActor { get; set; }
    }
}
