namespace GerenciamentoEscolaKensington
{
    public class VerificarInclusaoAluno
    {
        public string Aluno { get; set; } = new aluno();
        public string TurmaID { get; set; } = new turmaID();

        if (aluno != empty && turmaID != empty)
            {
            Console.WriteLine("Aluno incluído com sucesso!");
            } 
        else 
        {
            Console.WriteLine("Favor informar turma");
        }
    }

    internal class turmaID
    {
        public turmaID()
        {
        }

        public static implicit operator string(turmaID v)
        {
            throw new NotImplementedException();
        }
    }

    internal class aluno
    {
        public aluno()
        {
        }

        public static implicit operator string(aluno v)
        {
            throw new NotImplementedException();
        }
    }

}
