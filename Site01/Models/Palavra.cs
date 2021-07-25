using Site01.Library.Validation;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Palavra
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório!")]
        [MaxLength(70, ErrorMessage = "O campo 'Nome' deve conter no máximo 70 caracteres!")]
        [UnicoNomePalavra]
        public string Nome { get; set; }
        
        //1 - fácil, 2 - médio, 3 - difícil
        public byte Nivel { get; set; } //? indica que permite valores nulos
    }
}
