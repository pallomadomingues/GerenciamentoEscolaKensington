namespace GerenciamentoEscolaKensington.Context
{
    
    public static bool ConsultarAlunoPeloID(Usuario user1, Usuario user2)
    {
        if (user1 == null || user2 == null) { return false; }

        if (user1.ID == user2.ID)
        {
            erro = "O ID do aluno não foi encontrado!";
            return false;
        }
        return true;
    }
}
