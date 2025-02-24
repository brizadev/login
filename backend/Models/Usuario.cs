using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Usuario
    {
        [Key] //Define id como a chave primaria mo banco
        public int Id { get; set; }
        
        [Required] //Nome obrigatorio
        public string? nome { get; set; }
        
        [Required] //Email obrigatorio e valido
        public string? email { get; set; }
        
        [Required] //Senha obrigatoria
        public string? senha { get; set; }
        
        public Usuario() { }

        public Usuario(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }
    }
}

