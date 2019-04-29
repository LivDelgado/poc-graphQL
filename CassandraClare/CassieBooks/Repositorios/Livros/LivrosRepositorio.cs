using CassandraClare.Data.Livros;
using CassandraClare.Entidades.Livros;
using System.Collections.Generic;
using System.Linq;

namespace CassandraClare.Repositorios.Livros
{
    public class LivrosRepositorio : ILivrosRepositorio
    {
        public List<Livro> ListarLivros()
        {
            return LivrosData.GetLivros();
        }

        public Livro ObterLivro(string titulo)
        {
            return LivrosData.GetLivros().FirstOrDefault(x => x.Titulo == titulo);
        }
    }

    public interface ILivrosRepositorio
    {
        List<Livro> ListarLivros();
        Livro ObterLivro(string titulo);
    }
}
