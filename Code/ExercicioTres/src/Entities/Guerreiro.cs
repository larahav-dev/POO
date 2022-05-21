using System;
using System.Collections.Generic;

namespace ExercicioTres.src.Entities
{
    public class Guerreiro : Personagem
    {
        public List<string> Habilidades = new List<string>();

       public Guerreiro (string Nome, int Vida, int Mana, float XP, int Inteligencia, int Forca, int Level) : base(Nome, Vida, Mana, XP, Inteligencia, Forca, Level)
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

            //Guerreiro possui um aumento maior nos atributos Vida e Força.
            VidaPersonagem = VidaPersonagem + 25;
            ManaPersonagem = ManaPersonagem + 10;
            InteligenciaPersonagem = InteligenciaPersonagem + 10;
            ForcaPersonagem = ForcaPersonagem + 25;
        }

        public string attack()
        {  
            //Gera um número aleatório:
            Random rng = new Random();
            int Dano = rng.Next(0, 10);

            if (Dano > 0 && Dano <= 8)
            {
                return $"{NomePersonagem} disparou um golpe de espada causando {(ForcaPersonagem * LevelPersonagem) + rng.Next(0,300)} de dano.";
            }

            else if (Dano > 8 && Dano <= 10)
            {
                //Devido a chance aleatória do dano ter passado de 8 o dano será um crítico com 50% a mais de dano.
                return $"{NomePersonagem} disparou um golpe de espada poderoso causando {((ForcaPersonagem * LevelPersonagem) + rng.Next(0,300)) * 1.5} de dano.";
            }

            else
            {
                return $"O ataque de {NomePersonagem} não surtiu efeito.";
            }
        }

        public string aprenderHabilidade(string NomeHabilidade)
        {
            Habilidades.Add(NomeHabilidade);
            return $"{NomePersonagem} aprendeu {NomeHabilidade}.";
        }
    }
}