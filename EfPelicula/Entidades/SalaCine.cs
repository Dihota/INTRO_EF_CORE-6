using System.ComponentModel.DataAnnotations;

namespace EfPelicula.Entidades
{
    public class SalaCine
    {
        [Key]
        public int ID { get; set; }
        public decimal Precio { get; set; }
        public int CineID { get; set; }
        //Propiead de navegacion
        public Cine Cine { get; set; }
        //Propiedad para poder utilizar el tipo enums
        
        public HashSet<Pelicula> Pelicula { get; set; }
    }
}
