using ProjetoViagem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjetoViagem.Repository.Mapping
{
    public class VooMap : IEntityTypeConfiguration<Voo>
    {
        public void Configure(EntityTypeBuilder<Voo> builder)
        {
            builder.ToTable("Voo");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Data_voo)
            .IsRequired();

            builder.Property(prop => prop.Horario_saida)
            .IsRequired();

            builder.Property(prop => prop.Horario_chegada)
            .IsRequired();

            builder.Property(prop => prop.NumVoo)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(prop => prop.ValorVoo)
            .IsRequired()
            .HasColumnType("float");

            builder.HasOne(prop => prop.Origem);

            builder.HasOne(prop => prop.Destino);

            builder.Property(prop => prop.Empresa)
            .IsRequired()
            .HasColumnType("varchar(30)");

        }
    }
}
