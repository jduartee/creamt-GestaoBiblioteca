using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BibliotecaNet.Repository.Mappings
{
    public class PessoaDocumentoTipoMapping : IEntityTypeConfiguration<PessoaDocumentoTipo>
    {
        public void Configure(EntityTypeBuilder<PessoaDocumentoTipo> builder)
        {
            builder.HasKey(prop => prop.PessoaDocumentoTipoId);
            builder.Property(prop => prop.Descricao);
            builder.Property(prop => prop.Mascara);
            builder.Property(prop => prop.Obrigatorio);
            builder.Property(prop => prop.Ativo);

            builder.ToTable(nameof(PessoaDocumentoTipo));
        }
    }
}
