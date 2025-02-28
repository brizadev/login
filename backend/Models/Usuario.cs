using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Usuario
    {
        [Key] // Define Id como a chave primária no banco
        public int Id { get; set; }

        [Required] // Email obrigatório e válido
        public string Email { get; set; } = string.Empty; // Inicializado para evitar aviso CS8618

        [Required] // Senha obrigatória
        public string Senha { get; set; } = string.Empty; // Inicializado para evitar aviso CS8618

        public Usuario() { }

        public Usuario(string email, string senha)
        {
            this.Email = email;
            this.Senha = senha;
        }
    }
} 