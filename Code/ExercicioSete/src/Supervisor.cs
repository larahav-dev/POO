using System;
namespace ExercicioSete.src
{
    public class Supervisor: Funcionario
    {
        public override void Bonificacao()
        {
            Console.WriteLine("Digite o nome do Supervisor:");
            Nome = Console.ReadLine();
            
            Console.WriteLine("Digite a idade:");
            Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salario:");
            Salario = int.Parse(Console.ReadLine());

            Salario = Salario + 5000;
            Console.WriteLine($"O salario do supervisor {Nome} com a bonificação é {Salario}, e a sua idade é {Idade}");
        }
        
    }
}