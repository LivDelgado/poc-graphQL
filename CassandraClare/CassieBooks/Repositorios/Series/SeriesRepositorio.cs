using CassandraClare.Data.Series;
using CassandraClare.Entidades.Series;
using System.Collections.Generic;
using System.Linq;

namespace CassandraClare.Repositorios.Series
{
    public class SeriesRepositorio : ISeriesRepositorio
    {
        public List<Serie> ListarSeries()
        {
            return SeriesData.GetSeries();
        }

        public Serie ObterSerie(string nome)
        {
            return SeriesData.GetSeries().FirstOrDefault(x => x.Nome == nome);
        }
    }

    public interface ISeriesRepositorio
    {
        List<Serie> ListarSeries();
        Serie ObterSerie(string nome);
    }
}
