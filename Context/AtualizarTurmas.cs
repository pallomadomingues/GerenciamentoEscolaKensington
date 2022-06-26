namespace GerenciamentoEscolaKensington.Context
{
    public static bool AtualizarTurmas(Usuario sala1, Usuario sala2)
    {
        if (sala1 == null || sala2 == null) { return false; }

        if (sala1.Nome == sala2.Nome)
        {
            erro = "A turma inserida já existe na nossa base de dados!";
            return false;
        }
        return true;
    }
}
