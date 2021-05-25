using GerenciadorDeBiblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeBiblioteca.Configuration
{
    public class PalavraChaveConfiguration : IEntityTypeConfiguration<PalavraChave>
    {
        public void Configure(EntityTypeBuilder<PalavraChave> builder)
        {

            builder.HasKey(p => p.PalavraChaveID);

            builder.Property(p => p.Palavra_Chave)
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
