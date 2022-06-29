using CaiNaFesta.Data.Mapeamento;
using CaiNaFesta.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CaiNaFesta.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
{
}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EventoMapeamento());
            modelBuilder.ApplyConfiguration(new SuporteMapeamento());
            modelBuilder.ApplyConfiguration(new IngressoMapeamento());
        }
        public DbSet<EventoModel> Evento { get; set; }
        public DbSet<SuporteModel> Suporte { get; set; }
        public DbSet<IngressoModel> Ingresso { get; set; }
    }
}
