using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BibliotecaNet.Repository.Mappings
{
    public class AcervoEditoraMapping : IEntityTypeConfiguration<AcervoEditora>
    {

        public void Configure(EntityTypeBuilder<AcervoEditora> builder)
        {
            builder.HasKey(prop => prop.AcervoEditoraId);
            builder.Property(prop => prop.Nome);

            builder.ToTable(nameof(AcervoEditora));
        }
    }
}