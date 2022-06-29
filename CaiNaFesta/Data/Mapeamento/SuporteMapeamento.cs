using CaiNaFesta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace CaiNaFesta.Data.Mapeamento
{
    public class SuporteMapeamento : IEntityTypeConfiguration<SuporteModel>
    {
        public void Configure(EntityTypeBuilder<SuporteModel> builder)
        {
            builder.ToTable("Suporte");

            builder.HasKey(t => t.Id);
            {
                builder.Property(t => t.Nome).HasColumnType("varchar(50)");
                builder.Property(t => t.Email).HasColumnType("varchar(100)");
                builder.Property(t => t.Telefone).HasColumnType("varchar(15)");
                builder.Property(t => t.Descricao).HasColumnType("varchar(500)");            }
        }
    }
}
