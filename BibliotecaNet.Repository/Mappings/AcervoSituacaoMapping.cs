using BibliotecaNet.Common;
using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BibliotecaNet.Repository.Mappings
{
    public class AcervoSituacaoMapping : IEntityTypeConfiguration<AcervoSituacao>
    {
        public void Configure(EntityTypeBuilder<AcervoSituacao> builder)
        {
            builder.HasKey(prop => prop.AcervoSituacaoId);
            builder.Property(prop => prop.Descricao);
        }
    }
}
