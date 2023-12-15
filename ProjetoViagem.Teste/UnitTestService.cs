using System.Text.Json;
using AutoMapper;
using ProjetoViagem.Domain.Base;
using ProjetoViagem.Domain.Entities;
using ProjetoViagem.Repository.Context;
using ProjetoViagem.Repository.Repository;
using ProjetoViagem.Service.Services;
using ProjetoViagem.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ProjetoViagem.Teste
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;


        public ServiceProvider ConfiguraServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "ProjetoViagem";
                var username = "root";
                var password = "1122";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();

            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Usuario, Usuario>(); }).CreateMapper());
            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestUsuario()
        { 
            var sp = ConfiguraServices();
            var _userService = sp.GetService<IBaseService<Usuario>>();
            var usuario = new Usuario
            {
                Nome = "Sofia",
                Email = "sofia.bressa@hotmail.com",
                Senha = "1234", 
            };

            var result = _userService?.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}