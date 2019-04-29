using CassandraClare.Entidades.Livros;
using GraphQL.Types;


namespace CassandraClare.Data.Schema.Livros
{
    public class LivroType : ObjectGraphType<Livro>
    {
        public LivroType()
        {
            Field(x => x.Titulo).Description("Título do livro");
            Field(x => x.Ano).Description("Ano de lançamento do livro no Brasil");
            Field(x => x.Serie).Description("Série de livros da qual este faz parte");
        }
    }
}
