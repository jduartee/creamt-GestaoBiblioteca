using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BibliotecaNet.Repository.Mappings
{
    public class AcervoCategoriaMapping : IEntityTypeConfiguration<AcervoCategoria>
    {

        public void Configure(EntityTypeBuilder<AcervoCategoria> builder)
        {
            builder.HasKey(prop => prop.AcervoCategoriaId);
            builder.Property(prop => prop.Descricao);
            builder.Property(prop => prop.Ativo);

            builder.ToTable(nameof(AcervoCategoria));
        }
    }
}
