using GerenciadorDeBiblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeBiblioteca.Configuration
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.EnderecoId);

            builder.Property(p => p.Rua)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Coluna)
                .HasColumnType("varchar")
                .HasMaxLength(2)
                .IsRequired();

            builder.Property(p => p.Prateleira)
                .HasColumnType("int")
                .IsRequired();

            builder
                .HasMany(p => p.Livros);
        }
        
    }
}
