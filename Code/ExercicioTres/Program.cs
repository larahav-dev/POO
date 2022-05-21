using System;
using ExercicioTres.src.Entities;

namespace ExercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Mago TesteMago = new Mago("Mago Teste",100,100,50,25,10,1);
            Guerreiro TesteGuerreiro = new Guerreiro("Guerreiro Teste",100,100,50,25,10,1);

            //Testando:
            TesteMago.lvlup();
            Console.WriteLine(TesteMago.ToString() + "\n");
            Console.WriteLine(TesteMago.attack());
            Console.WriteLine(TesteMago.aprenderMagia("Trovão"));
            Console.WriteLine(TesteMago.aprenderMagia("Bola de fogo") + "\n");

            Console.WriteLine($"Lista de Magias de {TesteMago.NomePersonagem}:");
            foreach (string Magia in TesteMago.Magias)
            {
                Console.WriteLine($" - {Magia}");
            }
            
            Console.WriteLine("\n----------------------------\n");
            TesteGuerreiro.lvlup();
            Console.WriteLine(TesteGuerreiro.ToString() + "\n");
            Console.WriteLine(TesteGuerreiro.attack());
            Console.WriteLine(TesteGuerreiro.aprenderHabilidade("Pular"));
            Console.WriteLine(TesteGuerreiro.aprenderHabilidade("Foco") + "\n");

            Console.WriteLine($"Lista de Habilidades de {TesteGuerreiro.NomePersonagem}:");
            foreach (string Habilidade in TesteGuerreiro.Habilidades)
            {
                Console.WriteLine($" - {Habilidade}");
            }
            
        }

        public static int cont()
        {
            return + 1;
        }
    }
}
