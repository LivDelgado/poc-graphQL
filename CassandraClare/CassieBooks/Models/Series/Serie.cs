using CassandraClare.Entidades.Livros;
using System.Collections.Generic;

namespace CassandraClare.Entidades.Series
{
    public class Serie
    {
        public string Nome { get; set; }
        public List<Livro> Livros { get; set; }
    }
}
