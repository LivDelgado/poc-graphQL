using CassandraClare.Entidades.Livros;
using System.Collections.Generic;

namespace CassandraClare.Entidades.Personagens
{
    public class Personagem
    {
        public string ID { get; set; }
        public string Nome { get; set; }
        public string AnoNascimento { get; set; }
        public List<Livro> Livros { get; set; }
    }
}
