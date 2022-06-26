namespace GerenciamentoEscolaKensington.Context
{
    public class IncluirTurmas
    {
    }
    public static bool IncluirTurmas(Usuario sala1, Usuario sala2)
    {
        if (sala1 == null || sala2 == null) { return false; }

        if (sala1.ID == sala2.ID)
        {
            erro = "A turma não foi incluida!";
            return false;
        }
        return true;
    }
}
