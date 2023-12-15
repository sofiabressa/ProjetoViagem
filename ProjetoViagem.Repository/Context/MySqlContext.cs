using Microsoft.EntityFrameworkCore;
using ProjetoViagem.Domain.Entities;
using ProjetoViagem.Repository.Mapping;

namespace ProjetoViagem.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Cidade>? Cidade { get; set; }
        public DbSet<Voo>? Voo { get; set; }
        public DbSet<Usuario>? Usuario { get; set; }
        public DbSet<Viagem>? Viagem { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cidade> (new CidadeMap().Configure);
            modelBuilder.Entity<Voo>(new VooMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Viagem>(new ViagemMap().Configure);
        }
    }
}