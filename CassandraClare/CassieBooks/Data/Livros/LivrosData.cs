using CassandraClare.Entidades.Livros;
using System.Collections.Generic;

namespace CassandraClare.Data.Livros
{
    public static class LivrosData
    {
        private static Livro tid1 = new Livro() { Titulo = "Anjo Mecânico", Ano = "2010", Serie = "Peças Infernais" };
        private static Livro tid2 = new Livro() { Titulo = "Príncipe Mecânico", Ano = "2011", Serie = "Peças Infernais" };
        private static Livro tid3 = new Livro() { Titulo = "Princesa Mecânica", Ano = "2013", Serie = "Peças Infernais" };
        private static Livro tmi1 = new Livro() { Titulo = "Cidade dos Ossos", Ano = "2007", Serie = "Instrumentos Mortais" };
        private static Livro tmi2 = new Livro() { Titulo = "Cidade das Cinzas", Ano = "2008", Serie = "Instrumentos Mortais" };
        private static Livro tmi3 = new Livro() { Titulo = "Cidade de Vidro", Ano = "2009", Serie = "Instrumentos Mortais" };
        private static Livro tmi4 = new Livro() { Titulo = "Cidade dos Anjos Caídos", Ano = "2011", Serie = "Instrumentos Mortais" };
        private static Livro tmi5 = new Livro() { Titulo = "Cidade das Almas Perdidas", Ano = "2012", Serie = "Instrumentos Mortais" };
        private static Livro tmi6 = new Livro() { Titulo = "Cidade do Fogo Celestial", Ano = "2014", Serie = "Instrumentos Mortais" };
        private static Livro tda1 = new Livro() { Titulo = "Dama da Meia-Noite", Ano = "2016", Serie = "Artifícios das Trevas" };
        private static Livro tda2 = new Livro() { Titulo = "Senhor das Sombras", Ano = "2017", Serie = "Artifícios das Trevas" };
        private static Livro tda3 = new Livro() { Titulo = "Rainha do Ar e da Escuridão", Ano = "2019", Serie = "Artifícios das Trevas" };

        private static List<Livro> Livros = new List<Livro>
        {
            tid1, tid2, tid3, tmi1, tmi2, tmi3, tmi4, tmi5, tmi6, tda1, tda2, tda3
        };

        public static List<Livro> GetLivros()
        {
            return Livros;
        }

        public static Livro GetTID1()
        {
            return tid1;
        }
        public static Livro GetTID2()
        {
            return tid2;
        }
        public static Livro GetTID3()
        {
            return tid3;
        }
        public static Livro GetTMI1()
        {
            return tmi1;
        }
        public static Livro GetTMI2()
        {
            return tmi2;
        }
        public static Livro GetTMI3()
        {
            return tmi3;
        }
        public static Livro GetTMI4()
        {
            return tmi4;
        }
        public static Livro GetTMI5()
        {
            return tmi5;
        }
        public static Livro GetTMI6()
        {
            return tmi6;
        }
        public static Livro GetTDA1()
        {
            return tda1;
        }
        public static Livro GetTDA2()
        {
            return tda2;
        }
        public static Livro GetTDA3()
        {
            return tda3;
        }
    }
}
