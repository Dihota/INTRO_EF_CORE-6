using System.ComponentModel.DataAnnotations;

namespace EfPelicula.Entidades
{
    public class Cine
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        //propiedad tipo CineOferta, para realizar la relacion 1:1 en la otra tabla se declaro un campo cineID
        public CineOferta CineOferta { get; set; }
        //propiedad para la relacion uno a muchos, siempre va en la que tendra la relacion de 1
        public HashSet<SalaCine> SalaCines { get; set; }
    }
}
