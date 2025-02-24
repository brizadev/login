using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        // Tabelas
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração do modelo Usuario
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(u => u.Id); // Chave primária
                entity.Property(u => u.nome).IsRequired().HasMaxLength(100); // Nome é obrigatório
                entity.Property(u => u.email).IsRequired().HasMaxLength(150); // Email é obrigatório
            });

            
        }
    }
}