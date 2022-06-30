using CaiNaFesta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CaiNaFesta.Data.Mapeamento
{
    public class EventoMapeamento : IEntityTypeConfiguration<EventoModel>
    {
        public void Configure(EntityTypeBuilder<EventoModel> builder)
        {
            builder.ToTable("Evento");



            builder.HasKey(t => t.Id);
            {
                builder.Property(t => t.Nome).HasColumnType("varchar(100)");
                builder.Property(t => t.Data).HasColumnType("date");
                builder.Property(t => t.HoraInicio).HasColumnType("time(7)");
                builder.Property(t => t.HoraFim).HasColumnType("time(7)");
                builder.Property(t => t.Estado).HasColumnType("varchar(30)");
                builder.Property(t => t.Cidade).HasColumnType("varchar(50)");
                builder.Property(t => t.Descricao).HasColumnType("varchar(300)");
                builder.Property(t => t.Email).HasColumnType("varchar(50)");
                builder.Property(t => t.Lotacao).HasColumnType("int");
                builder.Property(t => t.Imagem).HasColumnType("varbinary(Max)");
            }
        }
    }
}
