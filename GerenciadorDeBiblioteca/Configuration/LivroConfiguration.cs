using GerenciadorDeBiblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeBiblioteca.Configuration
{
    public class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {

            builder.ToTable("Livros");

            builder.HasMany(p => p.PalavrasChave)
                .WithOne(p => p.Livro)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.HasKey(p => p.LivroID);

            builder.Property(p => p.Titulo)
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Autor)
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.ISBN)
                .HasColumnType("nvarchar")
                .HasMaxLength(17)
                .IsRequired();

            builder.Property(p => p.Editora)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Classificacao)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
