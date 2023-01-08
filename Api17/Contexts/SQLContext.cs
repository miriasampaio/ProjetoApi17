using Api17.models;
using Microsoft.EntityFrameworkCore;

namespace Api17.Contexts
{


    public class SQLContext : DbContext
    {
        public SQLContext() { }
        public SQLContext(DbContextOptions<SQLContext> options) : base(options) { }
        // vamos utilizar esse método para configurar o banco de  dados
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data  Source = SAMPAIO\\SQLEXPRESS; initial catalog = Chapter;  Integrated Security = true");
            }
        }
        // dbset representa as entidades que serão utilizadas  nas operações de leitura, criação, atualização e deleção
        public DbSet<Livro> Livros { get; set; }

    }

}