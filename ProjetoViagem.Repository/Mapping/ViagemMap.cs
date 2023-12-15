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

            builder.Property(prop => prop.Data_inicio)
            .IsRequired();

            builder.HasOne(prop => prop.Usuario);

            builder.HasOne(prop => prop.Origem);

            builder.HasOne(prop => prop.Destino);

            builder.HasOne(prop => prop.Voo);

        }
    }
}
