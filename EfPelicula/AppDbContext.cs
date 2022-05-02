using EfPelicula.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EfPelicula
{
    public class AppDbContext : DbContext
    {
        //Indicamos que se utilizara la inyeccion de dependencias
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        //Configuramos las convenciones (propiedades que se realizara para todos los campos similares)
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
        }

        //Se define onmodel creating donde van las propiedades de cada campo o se realiza el ensamblado 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<PeliculaActor>().HasKey(prop => new { prop.PeliculaID, prop.ActorID });

        }

        //Se agregan los dbset para indicar que son tablas de la BD
        public DbSet<Genero> Generos  { get; set; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Cine> Cines { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<CineOferta> CineOfertas { get; set; }
        public DbSet<SalaCine> SalaCines { get; set; }
        public DbSet<PeliculaActor> PeliculaActores { get; set; }
        
    }
}
