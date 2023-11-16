using ProjetoViagem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjetoViagem.Repository.Mapping
{
    public class ViagemMap : IEntityTypeConfiguration<Viagem>
    {
        public void Configure(EntityTypeBuilder<Viagem> builder)
        {
            builder.ToTable("Viagem");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Data_inicio);

            builder.Property(prop => prop.Data_fim);

            builder.Property(prop => prop.ValorViagem);

            builder.Property(prop => prop.Data_venda);

            builder.HasOne(prop => prop.Usuario);
        }
    }
}
