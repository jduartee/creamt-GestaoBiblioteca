using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Repository.Mappings
{
    public class PessoaContatoMapping : IEntityTypeConfiguration<PessoaContato>
    {
        public void Configure(EntityTypeBuilder<PessoaContato> builder)
        {
            builder.HasKey(p => p.PessoaContatoId);
            builder.Property(p => p.Valor).IsRequired();

            builder.ToTable("PessoaContato");
        }
    }
}
