using GerenciamentoEscolaKensington.Model;

namespace GerenciamentoEscolaKensington
{
    public class VerificarExclusaoTurma
    {
        public string Turma = new turmaID();
        public string Aluno = new aluno();
        if (Turma != aluno==0)
            { Console.WriteLine("Sala nao pode ser deletada.");
            } else{ 
            WebRequest request = WebRequest.Create(sURL);
            request.Method = "DELETE";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            }       
    }

}
