using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Repository.Mappings
{
    public class AcervoAutorMapping : IEntityTypeConfiguration<AcervoAutor>
    {

        public void Configure(EntityTypeBuilder<AcervoAutor> builder)
        {
            builder.HasKey(prop => prop.AcervoAutorId);
            builder.ToTable(nameof(AcervoAutor));
        }
    }
}
