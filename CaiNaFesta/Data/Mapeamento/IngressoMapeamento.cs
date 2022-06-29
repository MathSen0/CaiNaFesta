using CaiNaFesta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaiNaFesta.Data.Mapeamento
{
    public class IngressoMapeamento : IEntityTypeConfiguration<IngressoModel>
    {
        public void Configure(EntityTypeBuilder<IngressoModel> builder)
        {
            builder.ToTable("Ingresso");

            builder.HasKey(t => t.Id);
            {
                builder.Property(t => t.Nome).HasColumnType("varchar(100)");
                builder.Property(t => t.Email).HasColumnType("varchar(100)");
                builder.Property(t => t.IdEvento).HasColumnType("int)");
                builder.Property(t => t.Data).HasColumnType("date");
            }
        }
    }
}
