using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(u => u.Id); // Chave primária
                entity.Property(u => u.Email).IsRequired().HasMaxLength(150); // Email é obrigatório
                entity.Property(u => u.Senha).IsRequired().HasMaxLength(100); // Senha é obrigatória
            });
        }
    }
}