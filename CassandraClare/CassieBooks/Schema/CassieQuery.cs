using CassandraClare.Data.Schema.Livros;
using CassandraClare.Data.Schema.Series;
using CassandraClare.Repositorios.Livros;
using CassandraClare.Repositorios.Series;
using GraphQL.Types;

namespace CassandraClareBooks.Schema
{
    public class CassieQuery : ObjectGraphType
    {
        public CassieQuery(ILivrosRepositorio livrosRepositorio, ISeriesRepositorio seriesRepositorio)
        {
            Name = "Query";
            Field<SerieType>(
              "serie",
              arguments: new QueryArguments(
                    new QueryArgument<StringGraphType> { Name = "nome", Description = "Se omitido, retorna a série Instrumentos Mortais" }
              ),
              resolve: context =>
              {
                  var titulo = context.GetArgument<string>("nome");
                  return seriesRepositorio.ObterSerie(titulo);
              }
            );

            Field<LivroType>(
                "livro",
              arguments: new QueryArguments(
                    new QueryArgument<StringGraphType> { Name = "titulo" }
              ),
              resolve: context =>
              {
                  var titulo = context.GetArgument<string>("nome");
                  return livrosRepositorio.ObterLivro(titulo);
              }
            );
        }
    }
}
