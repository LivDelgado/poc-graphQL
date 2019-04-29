using CassandraClare.Entidades.Personagens;
using System.Collections.Generic;

namespace CassandraClare.Data.Personagens
{
    public static class VampirosData
    {
        private static List<Vampiro> Vampiros = new List<Vampiro>
        {
            new Vampiro(){ID = "001", AnoNascimento = "", Livros = null, Nome = "" },

        };

        public static List<Vampiro> GetVampiros()
        {
            return Vampiros;
        }
    }
}
