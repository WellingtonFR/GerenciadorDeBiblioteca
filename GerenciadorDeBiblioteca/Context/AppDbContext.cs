using GerenciadorDeBiblioteca.Configuration;
using GerenciadorDeBiblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeBiblioteca.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new LivroConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

    }
}
