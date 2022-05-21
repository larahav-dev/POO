using System;
namespace ExercicioSete.src
{
    public class Vendedor: Funcionario
    {
        public override void Bonificacao()
        {
            Console.WriteLine("Digite o nome do Vendedor:");
            Nome = Console.ReadLine();
            
            Console.WriteLine("Digite a idade:");
            Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salario:");
            Salario = int.Parse(Console.ReadLine());
        
            Salario = Salario + 3000;
            Console.WriteLine($"O salario do vendedor {Nome} com a bonificação é {Salario}, e a sua idade é {Idade}");
        }
    }
}