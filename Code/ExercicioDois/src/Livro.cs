namespace ExercicioDois.src
{
    public class Livro
    {
        private string Autor{get; set;}
        private double Tema{get; set;}
        private int QtdPag{get; set;}

        public Livro()
        {

        }
        public Livro(string autor, double tema, int qtdPag)
        {
            Autor = autor;
            Tema = tema;
            QtdPag = qtdPag;
        }
        

    }
}