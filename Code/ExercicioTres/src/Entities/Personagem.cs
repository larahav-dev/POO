namespace ExercicioTres.src.Entities
{
    public class Personagem
    {
        //Declarando variaveis:
        #region "Variaveis Getters/Setters"
        public string NomePersonagem { get; set; }
        public int VidaPersonagem { get; set; }
        public int ManaPersonagem { get; set; }
        public float XpPersonagem { get; set; }
        public int InteligenciaPersonagem { get; set; }
        public int ForcaPersonagem { get; set; }
        public int LevelPersonagem { get; set; } 
        #endregion

        //Método construtor:
        public Personagem(string Nome, int Vida, int Mana, float XP, int Inteligencia, int Forca, int Level)
        {
            this.NomePersonagem = Nome;
            this.VidaPersonagem = Vida;
            this.ManaPersonagem = Mana;
            this.XpPersonagem = XP;
            this.InteligenciaPersonagem = Inteligencia;
            this.ForcaPersonagem = Forca;
            this.LevelPersonagem = Level;
        }

        public override string ToString()
        {
            return
                "Nome: "                + this.NomePersonagem +
                "\nLevel: "             + this.LevelPersonagem +
                "\nXP: "                + this.XpPersonagem +
                "\nVida: "              + this.VidaPersonagem +
                "\nMana: "              + this.ManaPersonagem +
                "\nForça: "             + this.ForcaPersonagem +
                "\nInteligência: "      + this.InteligenciaPersonagem;
        }

        public virtual void lvlup()
        { 
            LevelPersonagem = LevelPersonagem + 1;  
            XpPersonagem = 0; //XP reinicia a cada level
            VidaPersonagem = VidaPersonagem + 10;
            ManaPersonagem = ManaPersonagem + 10;
            InteligenciaPersonagem = InteligenciaPersonagem + 10;
            ForcaPersonagem = ForcaPersonagem + 10;
        }

    }
}