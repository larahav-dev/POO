using System.Linq;
using System.Collections.Generic;
using ExercicioQuartoCincoSeis.src;
using ExercicioQuartoCincoSeis.Helper;

namespace ExercicioQuartoCincoSeis
{
    class Program
    {
        static void Main(string[] args)
        {
           OperacoesLista opLista = new OperacoesLista();
            List<string> Nome = new List<string> { "João", "Leandro", "Paulo","Jessica" };
            List<int> Idade = new List<int> { 15, 21, 17,18 };
            
            opLista.ImprimirListaString(Nome);




        }
    }
}
