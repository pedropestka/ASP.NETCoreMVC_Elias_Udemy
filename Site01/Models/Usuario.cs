using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Usuario
    {    
        [Required(ErrorMessage = "O campo 'E-Mail' é obrigatório!")]
        [EmailAddress(ErrorMessage = "O campo 'E-mail' é inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo 'Senha' é obrigatório!")]
        public string Senha { get; set; }
    }
}
