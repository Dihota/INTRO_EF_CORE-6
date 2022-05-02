using System.ComponentModel.DataAnnotations;

namespace EfPelicula.Entidades
{
    public class Genero
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        //propiedad para la relacion muchos a muchos
        public HashSet<Pelicula> Pelicula { get; set; }
    }
}
