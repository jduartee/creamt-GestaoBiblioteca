using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BibliotecaNet.Repository.Mappings
{
    public class AcervoMovimentacaoMapping : IEntityTypeConfiguration<AcervoMovimentacao>
    {
        public void Configure(EntityTypeBuilder<AcervoMovimentacao> builder)
        {
            builder.HasKey(prop => prop.AcervoMovimentacaoId);
            builder.Property(prop => prop.Acervo);
            builder.Property(prop => prop.DataEmprestimo);
            builder.Property(prop => prop.DataPrazoDevolucao);
            builder.Property(prop => prop.DataDevolucao);

            builder.ToTable(nameof(AcervoMovimentacao));
        }
    }
}
