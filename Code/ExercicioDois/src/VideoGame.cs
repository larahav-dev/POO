namespace ExercicioDois.src
{
    public class VideoGame
    {
        private string Autor{get; set;}
        private double Tema{get; set;}
        private int QtdPag{get; set;}

        public VideoGame()
        {
            
        }
        public VideoGame(string autor, double tema, int qtdPag)
        {
            Autor = autor;
            Tema = tema;
            QtdPag = qtdPag;
        }
    }
}