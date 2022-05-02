using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfPelicula.Entidades.Configuracion
{
    public class ConfigSalaCine : IEntityTypeConfiguration<SalaCine>
    {
        public void Configure(EntityTypeBuilder<SalaCine> builder)
        {
            builder.Property(prop => prop.Precio)
                .HasPrecision(precision:9,scale:2);

        }
    }
}
