namespace EfPelicula.Entidades
{
    public class Pelicula
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public bool EnCartelera { get; set; }
        public DateTime? FechaEstreno { get; set; }
        public string PosterUrl { get; set; }
        //propiedad para la relacion muchos a muchos
        public HashSet<Genero> Genero { get; set; }
        public HashSet<SalaCine> SalaCine { get; set; }
        public HashSet<PeliculaActor> PeliculaActors{ get; set; }


    }
}

