using CassandraClare.Data.Schema.Livros;
using CassandraClare.Entidades.Series;
using CassandraClare.Repositorios.Livros;
using GraphQL.Types;
using System.Linq;

namespace CassandraClare.Data.Schema.Series
{
    public class SerieType : ObjectGraphType<Serie>
    {
        public SerieType(ILivrosRepositorio livrosRepositorio)
        {
            Field(x => x.Nome).Description("Nome da série de livros");

            Field<ListGraphType<LivroType>>(
                "livros",
                resolve: context =>
                {
                    var livros = livrosRepositorio.ListarLivros().Where(x => x.Serie == context.Source.Nome);
                    return livros;
                }
            );
        }
    }
}
