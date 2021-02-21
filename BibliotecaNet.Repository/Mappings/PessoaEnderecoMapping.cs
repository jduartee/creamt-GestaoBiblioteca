using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Repository.Mappings
{
    public class PessoaEnderecoMapping : IEntityTypeConfiguration<PessoaEndereco>
    {
        public void Configure(EntityTypeBuilder<PessoaEndereco> builder)
        {
            builder.HasKey(x => x.PessoaEnderecoId);
            builder.Property(p => p.Cep)
                    .IsRequired()
                    .HasColumnType("varchar(11)");

            builder.Property(p => p.Cidade)
                   .IsRequired()
                   .HasColumnType("varchar(200)");

            builder.Property(p => p.Bairro)
                   .IsRequired()
                   .HasColumnType("varchar(200)");

            builder.Property(p => p.Logradouro)
                   .IsRequired()
                   .HasColumnType("varchar(200)");

            builder.Property(p => p.Numero)
                   .IsRequired()
                   .HasColumnType("varchar(30)");

            builder.Property(p => p.Complemento)
                   .IsRequired()
                   .HasColumnType("varchar(500)");

            builder.Property(p => p.Principal);

            builder.ToTable("PessoaEndereco");
        }
    }
}
