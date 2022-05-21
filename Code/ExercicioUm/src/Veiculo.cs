using System;
namespace ExercicioUm.src
{

    public class Veiculo
    {
        #region "Declarando variaveis"
        //Declarando variaveis/propriedades de um objeto:
        private string MarcaVeiculo { get; set; }
        private string ModeloVeiculo { get; set; }
        private string PlacaVeiculo { get; set; }
        private string CorVeiculo { get; set; }
        private float KmVeiculo { get; set; }
        private Boolean IsLigadoVeiculo { get; set; }
        private int LitroCombustivelVeiculo { get; set; }
        private int VelocidadeVeiculo { get; set; }
        private double PrecoVeiculo { get; set; }

        #endregion

        #region "Metodo Construtor"
        public Veiculo(string Marca, string Modelo, string Placa, string Cor, float Km,Boolean IsLigado, int LitroCombustivel,int Velocidade, double Preco)
        {
            this.MarcaVeiculo = Marca;
            this.ModeloVeiculo = Modelo;
            this.PlacaVeiculo = Placa;
            this.CorVeiculo = Cor;
            this.KmVeiculo = Km;
            this.IsLigadoVeiculo = IsLigado;
            this.LitroCombustivelVeiculo = LitroCombustivel;
            this.VelocidadeVeiculo = Velocidade;
            this.PrecoVeiculo = Preco;
        }
        #endregion

         #region "Funcao"
        /*Declarando uma função para retornar as informações*/
        public void Acelerar()
        {
            VelocidadeVeiculo = VelocidadeVeiculo + 20;
            Console.WriteLine($"A Velocidade perfomada é {VelocidadeVeiculo}km/h.");
        }
        public void Abastecer(int Combustivel)
        {
            this.LitroCombustivelVeiculo = Combustivel;
            if(Combustivel<= 60)
            {
                Console.WriteLine($"O Tanque está com {Combustivel} Litros de gasolina.");
            }
            else if(Combustivel > 60)
            {

                Combustivel = 60;
                Console.WriteLine($"O Tanque foi cheio, e está com {Combustivel} Litros de gasolina.");

            }
        }
        public void Frear()
        {
            if(IsLigadoVeiculo == true)
            {
                VelocidadeVeiculo = VelocidadeVeiculo - 20;
                Console.WriteLine($" O Veiculo desacelerou para {VelocidadeVeiculo}Km/h e freiou.");
            }
        }
        public void Pintar(string CorVeiculo)
        {
            this.CorVeiculo = CorVeiculo;
            Console.WriteLine($"A cor do veiculo é {CorVeiculo}");
        }
        public void Ligar()
        {
            if (IsLigadoVeiculo == true)
            {
               Console.WriteLine("O seu Veiculo já está ligado."); 
            }
            else
            {
                Console.WriteLine("O seu Veiculo foi ligado.");
            }
        }
        public void Desligar()
        {
            if (IsLigadoVeiculo == true || VelocidadeVeiculo > 0)
            {
                IsLigadoVeiculo = false;
                Console.WriteLine("Veículo desligado com sucesso!");
            }
            
            else
            {
                Console.WriteLine("O Veiculo ja está desligado.");
            }
            
        }

        #endregion

    }
}