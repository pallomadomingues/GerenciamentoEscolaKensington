namespace GerenciamentoEscolaKensington.Context
{
    
    public static bool ConsultarTodosOsAlunos(Usuario user1, Usuario user2)
    {
        if (user1 == null || user2 == null) { return false; }

        if (user1.ID == user2.ID)
        {
            erro = "A lista de alunos não foi encontrada!";
            return false;
        }
        return true;
    }
}
