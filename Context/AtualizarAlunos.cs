namespace GerenciamentoEscolaKensington.Context
{
    
    public static bool AtualizarAlunos(Usuario user1, Usuario user2)
    {
        if (user1 == null || user2 == null) { return false; }

        if (user1.Nome == user2.Nome)
        {
            erro = "O Aluno inseirdo já existe na nossa base de dados!";
            return false;
        }
        return true;
    }
}
