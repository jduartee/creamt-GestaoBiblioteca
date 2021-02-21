using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Repository.Mappings
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(x => x.PessoaId);
            builder.Property(x => x.MatriculaId);
            builder.Property(x => x.Nome);
            builder.Property(x => x.Ativo);

            builder.ToTable("Pessoa");
        }
    }
}
