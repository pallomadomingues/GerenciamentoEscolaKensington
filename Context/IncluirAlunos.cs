namespace GerenciamentoEscolaKensington.Context
{
    
    public static bool IncluirAlunos(Usuario user1, Usuario user2)
    {
        if (user1 == null || user2 == null) { return false; }

        if (user1.ID == user2.ID)
        {
            erro = "O aluno não foi incluido!";
            return false;
        }
        return true;
    }
}
