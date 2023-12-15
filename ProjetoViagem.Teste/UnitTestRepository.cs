using System.Text.Json;
using ProjetoViagem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ProjetoViagem.Teste
{
    [TestClass]
    public class UnitTestRepository

    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Usuario> Usuario { get; set; }
            public DbSet<Cidade> Cidade { get; set; }
            public DbSet<Voo> Voo { get; set; }
            public DbSet<Viagem> Viagem { get; set; }

            public MyDbContext()
            {

                //Database.EnsureCreated();

            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "ProjetoViagem";
                var username = "root";
                var password = "1122";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

            }
        }
        
        [TestMethod]
        public void TestInsertUsuarios()
        {
            using (var context = new MyDbContext())
            {

                var usuario = new Usuario
                {
                    Nome = "Sofia",
                    Email = "sofia.bressa@hotmail.com",
                    Senha = "1234",
                };
                context.Usuario.Add(usuario);
                
                usuario = new Usuario
                {
                    Nome = "Caio",
                    Email = "caio.hespporte@gmail.com",
                    Senha = "1234",
                };
                context.Usuario.Add(usuario);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListarUsuarios()
        {
            using (var context = new MyDbContext())
            {
                foreach (var usuario in context.Usuario)
                {
                    Console.WriteLine(JsonSerializer.Serialize(usuario));
                }
            }
        }
    }
}