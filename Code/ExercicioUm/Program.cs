using System;
using ExercicioUm.src;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo("Fiat","Palio","VFR-0887","Branco",100,false,10,0,25250.5);
            veiculo.Abastecer(40);
            veiculo.Acelerar();
            veiculo.Frear();
            veiculo.Pintar("Cinza");
            veiculo.Ligar();
            veiculo.Desligar();
        }
    }
}
