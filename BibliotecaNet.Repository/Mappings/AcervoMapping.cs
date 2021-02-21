using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BibliotecaNet.Repository.Mappings
{
    public class AcervoMapping : IEntityTypeConfiguration<Acervo>
    {
        public void Configure(EntityTypeBuilder<Acervo> builder)
        {
            builder.HasKey(prop => prop.AcervoId);
            builder.Property(prop => prop.Titulo);
            builder.Property(prop => prop.Edicao);
            builder.Property(prop => prop.Ano);

            builder.ToTable(nameof(Acervo));
        }
    }
}
