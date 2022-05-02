using System.ComponentModel.DataAnnotations;

namespace EfPelicula.Entidades
{
    public class CineOferta
    {
        [Key]
        public int ID { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal Porcentaje { get; set; }
        public int CineID { get; set; }

    }
}
