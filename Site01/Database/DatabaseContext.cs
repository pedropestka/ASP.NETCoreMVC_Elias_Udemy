using Microsoft.EntityFrameworkCore;
using Site01.Models;

namespace Site01.Database
{
    public class DatabaseContext : DbContext
    {
        // quais modelos vamos precisar no banco de dados

        // Modelo para o qual vamos criar uma tabela
        public DbSet<Palavra> Palavras { get; set; }


        // construtor
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            // EF - garanta que o banco de dados seja criado
            Database.EnsureCreated();
        }
    }
}