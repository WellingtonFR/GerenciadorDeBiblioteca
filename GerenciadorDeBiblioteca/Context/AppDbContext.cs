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
        }

        public DbSet<Livro> Livros { get; set; }

    }
}
