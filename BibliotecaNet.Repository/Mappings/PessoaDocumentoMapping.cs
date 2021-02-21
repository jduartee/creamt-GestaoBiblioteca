using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BibliotecaNet.Repository.Mappings
{
    public class PessoaDocumentoMapping : IEntityTypeConfiguration<PessoaDocumento>
    {
        public void Configure(EntityTypeBuilder<PessoaDocumento> builder)
        {
            builder.HasKey(prop => prop.PessoaDocumentoId);
            builder.Property(prop => prop.Valor);

            builder.ToTable(nameof(PessoaDocumento));
        }
    }
}
