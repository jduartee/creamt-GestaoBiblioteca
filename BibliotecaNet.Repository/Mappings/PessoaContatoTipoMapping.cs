using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Repository.Mappings
{
    public class PessoaContatoTipoMapping : IEntityTypeConfiguration<PessoaContatoTipo>
    {
        public void Configure(EntityTypeBuilder<PessoaContatoTipo> builder)
        {
            builder.HasKey(prop => prop.PessoaContatoTipoId);
            builder.Property(prop => prop.Descricao);
            builder.Property(prop => prop.Mascara);
            builder.Property(prop => prop.Obrigatorio);
            builder.Property(prop => prop.Ativo);
        }
    }
}
