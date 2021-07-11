
namespace Site01.Models
{
    public class Palavra
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        
        //1 - fácil, 2 - médio, 3 - difícil
        public byte Nivel { get; set; } //? indica que permite valores nulos
    }
}
