using System.ComponentModel.DataAnnotations;

namespace EfPelicula.Entidades
{
    public class PeliculaActor
    {
        [Key]
        public int PeliculaID { get; set; }
        public int ActorID { get; set; }
        public string Personaje { get; set; }
        public int Orden { get; set; }
        public Pelicula Pelicula { get; set; }
        public Actor Actor { get; set; }
    }
}
