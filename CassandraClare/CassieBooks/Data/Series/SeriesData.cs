using CassandraClare.Data.Livros;
using CassandraClare.Entidades.Livros;
using CassandraClare.Entidades.Series;
using System.Collections.Generic;

namespace CassandraClare.Data.Series
{
    public static class SeriesData
    {
        private static readonly Serie TID = new Serie
        {
            Nome = "Peças Infernais"
        };
        private static readonly Serie TMI = new Serie
        {
            Nome = "Instrumentos Mortais"
        };
        private static readonly Serie TDA = new Serie
        {
            Nome = "Artifícios das Trevas"
        };

        private static List<Serie> Series = new List<Serie> { TID, TMI, TDA };

        public static List<Serie> GetSeries()
        {
            return Series;
        }
    }
}
