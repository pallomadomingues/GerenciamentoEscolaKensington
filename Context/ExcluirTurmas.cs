namespace GerenciamentoEscolaKensington.Context
{
    
    public static bool ExcluirTurmas(Usuario sala1, Usuario sala2)
    {
        if (sala1 == null || sala2 == null) { return false; }

        if (sala1.ID == sala2.ID)
        {
            erro = "A turma não foi excluida!";
            return false;
        }
        return true;
    }
}
