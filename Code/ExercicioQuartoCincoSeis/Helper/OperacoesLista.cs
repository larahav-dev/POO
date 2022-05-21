using System.Collections.Generic;
namespace ExercicioQuartoCincoSeis.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"ID {i}, Nome: {lista[i]} Idade{lista[i]}");
            }
        }
    }
}