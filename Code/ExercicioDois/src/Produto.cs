namespace ExercicioDois.src
{
    abstract class Produto
    {
        private string Nome{get; set;}
        private double Preco{get; set;}
        private int Qtd{get; set;}

        public Produto(string nome, double preco, int qtd)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
        }
    }
}