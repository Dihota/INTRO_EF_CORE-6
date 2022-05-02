using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfPelicula.Entidades.Configuracion
{
    public class ConfigCineOferta : IEntityTypeConfiguration<CineOferta>
    {
        public void Configure(EntityTypeBuilder<CineOferta> builder)
        {
            builder.Property(prop => prop.Porcentaje)
                .HasPrecision(precision:5, scale:2);
        }
    }
}
