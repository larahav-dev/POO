using ExercicioDois.src;
namespace ExercicioDois.src
{
    public class Loja
    {
        private string Nome{get; set;}
        private double CNPJ{get; set;}
        private list<Livro> Livros{get; set;}
        private list<VideoGame> VideoGames{get; set;}

        public Loja()
        {

        }

        public Loja(string nome, double cNPJ, list<Livro> livros, list<VideoGame> videoGames)
        {
            Nome = nome;
            CNPJ = cNPJ;
            Livros = livros;
            VideoGames = videoGames;
        }
    }
}