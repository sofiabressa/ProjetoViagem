using ProjetoViagem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjetoViagem.Repository.Mapping
{
    public class DestinoMap : IEntityTypeConfiguration<Destino>
    {
        public void Configure(EntityTypeBuilder<Destino> builder)
        {
            builder.ToTable("Destino");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Descricao)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasOne(prop => prop.Viagem);
        }
    }
}