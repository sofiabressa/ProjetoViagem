using AutoMapper;
using ProjetoViagem.App.Models;
using ProjetoViagem.Domain.Base;
using ProjetoViagem.Domain.Entities;
using ProjetoViagem.Repository.Context;
using ProjetoViagem.Repository.Repository;
using ProjetoViagem.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjetoViagem.App.Base;
using ProjetoViagem.App.Outros;
using ProjetoViagem.App.Viagens;
using ProjetoViagem.App.Cadastros;

namespace ProjetoViagem.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            var strCon = File.ReadAllText("C:/Users/sofia/Documents/POE6/Viagem/ProjetoViagem.App/Config/DatabaseSettings.txt");
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                    .EnableSensitiveDataLogging();
                //options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                //options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Voo>, BaseRepository<Voo>>();
            Services.AddScoped<IBaseRepository<Viagem>, BaseRepository<Viagem>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();

            // Services
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Viagem>, BaseService<Viagem>>();
            Services.AddScoped<IBaseService<Voo>, BaseService<Voo>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();


            // Formulários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroBase, CadastroBase>();
            Services.AddTransient<Principal, Principal>();
            Services.AddTransient<MinhasViagens, MinhasViagens>();
            Services.AddTransient<NovaViagem, NovaViagem>();
            Services.AddTransient<cadastroVoo, cadastroVoo>();
            Services.AddTransient<ListarPassagens, ListarPassagens>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, UsuarioModel>();

                config.CreateMap<Viagem, ViagemModel>()
                .ForMember(d => d.Voo, opt => opt.MapFrom(x => new VooModel{
                    Data_voo = x.Voo!.Data_voo,
                    Horario_saida = x.Voo!.Horario_saida,
                    Horario_chegada = x.Voo!.Horario_chegada,
                    NumVoo = x.Voo!.NumVoo,
                    ValorVoo = x.Voo!.ValorVoo,
                    Empresa = x.Voo!.Empresa,
                }))
                .ForMember(d => d.Voo, d => d.MapFrom(x => x.Voo!.Id))
                .ForMember(d => d.Data_inicio, opt => opt.MapFrom(x => x.Data_inicio))
                .ForMember(d => d.Usuario, opt => opt.MapFrom(x => x.Usuario))
                .ForMember(d => d.Destino, opt => opt.MapFrom(x => x.Destino))
                .ForMember(d => d.Origem, opt => opt.MapFrom(x => x.Origem));

                /*config.CreateMap<Viagem, ViagemModel>()
                .ForMember(d => d.Voo, d => d.MapFrom(x => x.Voo!.Id))
                .ForMember(d => d.Voo.Data_voo, d => d.MapFrom(x => x.Voo!.Data_voo))
                .ForMember(d => d.Voo.Horario_saida, d => d.MapFrom(x => x.Voo!.Horario_saida))
                .ForMember(d => d.Voo.Horario_chegada, d => d.MapFrom(x => x.Voo!.Horario_chegada))
                .ForMember(d => d.Voo.NumVoo, d => d.MapFrom(x => x.Voo!.NumVoo))
                .ForMember(d => d.Voo.ValorVoo, d => d.MapFrom(x => x.Voo!.ValorVoo))
                .ForMember(d => d.Voo.Empresa, d => d.MapFrom(x => x.Voo!.Empresa))
                .ForMember(d => d.Voo, d => d.MapFrom(x => x.Voo!.Origem))
                .ForMember(d => d.Voo, d => d.MapFrom(x => x.Voo!.Destino));*/

                config.CreateMap<Cidade, CidadeModel>();

                config.CreateMap<Voo, VooModel>()
                .ForMember(d => d.Origem, d => d.MapFrom(x => x.Origem!.Nome))
                .ForMember(d => d.Destino, d => d.MapFrom(x => x.Destino!.Nome));

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
