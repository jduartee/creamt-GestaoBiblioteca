using BibliotecaNet.Common;
using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BibliotecaNet.Repository.Mappings
{
    public class PessoaTipoMapping : IEntityTypeConfiguration<PessoaTipo>
    {
        public void Configure(EntityTypeBuilder<PessoaTipo> builder)
        {
            builder.HasKey(prop => prop.PessoaTipoId);
            builder.Property(prop => prop.Descricao);

            builder.ToTable(nameof(PessoaTipo));
        }
    }
}