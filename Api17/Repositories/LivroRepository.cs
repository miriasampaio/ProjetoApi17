using Api17.Contexts;
using Api17.models;

namespace Api17.Repositories
{
    public class LivroRepository
    {
        private readonly SQLContext _context;
        public LivroRepository(SQLContext context)
        {
            _context = context;
        }

        public List<Livro> Listar()
         {
            return _context.Livros.ToList();
         }



    }
}
