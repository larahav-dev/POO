using System;
using System.Collections.Generic;

namespace ExercicioTres.src.Entities
{
    public class Mago : Personagem
    {
        //Lista de magias do mago
        public List<string> Magias = new List<string>();
        
        public Mago (string Nome, int Vida, int Mana, float XP, int Inteligencia, int Forca, int Level) : base(Nome, Vida, Mana, XP, Inteligencia, Forca, Level)
        {
            this.NomePersonagem = Nome;
            this.VidaPersonagem = Vida;
            this.ManaPersonagem = Mana;
            this.XpPersonagem = XP;
            this.InteligenciaPersonagem = Inteligencia;
            this.ForcaPersonagem = Forca;
            this.LevelPersonagem = Level;
        }

        public override void lvlup()
        {
            LevelPersonagem = LevelPersonagem + 1;  
            XpPersonagem = 0; //XP reinicia a cada level

            //Mago ao subir de nível possui um aumento maior nos atributos Mana e Inteligência.
            VidaPersonagem = VidaPersonagem + 10;
            ManaPersonagem = ManaPersonagem + 25;
            InteligenciaPersonagem = InteligenciaPersonagem + 25;
            ForcaPersonagem = ForcaPersonagem + 10;
        }

        public string attack()
        {  
            //Gera um número aleatório:
            Random rng = new Random();
            int Dano = rng.Next(0, 10);

            if (Dano > 0 && Dano <= 8)
            {
                return $"{NomePersonagem} disparou uma magia causando {(InteligenciaPersonagem * LevelPersonagem) + rng.Next(0,300)} de dano.";
            }

            else if (Dano > 8 && Dano <= 10)
            {
                //Devido a chance aleatória do dano ter passado de 8 o dano sera um crítico com 50% a mais de dano.
                return $"{NomePersonagem} disparou uma magia poderosa causando {((InteligenciaPersonagem * LevelPersonagem) + rng.Next(0,300)) * 1.5} de dano.";
            }

            else
            {
                return $"O ataque de {NomePersonagem} não surtiu efeito.";
            }
        }

        public string aprenderMagia(string NomeMagia)
        {
            Magias.Add(NomeMagia);
            return $"{NomePersonagem} aprendeu {NomeMagia}.";
        }
    }
}