namespace ExercicioSete.src
{
    public class Funcionario
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
        public double Salario {get; set;}

        public virtual void Bonificacao()
        {
        }
    }
}