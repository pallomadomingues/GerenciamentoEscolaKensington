namespace GerenciamentoEscolaKensington.Context
{
    
    public static bool ConsultarTurmaPeloID(Usuario sala1, Usuario sala2)
    {
        if (sala1 == null || sala2 == null) { return false; }

        if (sala1.ID == sala2.ID)
        {
            erro = "A turma não foi encontrada!";
            return false;
        }
        return true;
    }
}
