using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfPelicula.Entidades.Configuracion
{
    public class ConfigPelicula : IEntityTypeConfiguration<Pelicula>
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder)
        {
            builder.Property(prop => prop.Titulo)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(prop => prop.PosterUrl)
                .HasMaxLength(500)
                .IsUnicode(true);
        }
    }
}
