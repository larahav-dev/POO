namespace ExercicioSete.src
{
    public class Principal
    {
        public void telaPrincipal()
        {
            Vendedor p = new Vendedor();
            p.Bonificacao();
            Supervisor p2 = new Supervisor();
            p2.Bonificacao();
            Gerente p3 = new Gerente();
            p3.Bonificacao();
        }
    }
}