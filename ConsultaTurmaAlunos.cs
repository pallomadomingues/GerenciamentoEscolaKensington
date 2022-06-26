using Azure.Core;

namespace GerenciamentoEscolaKensington
{
    public class ConsultaTurmaAlunos
    {
        var url = "http://localhost:7084";//*alterar nº de porta

        var request = WebRequest.Create(url);
        Request.Method = "GET";

        using var webResponse = request.GetResponse();
        using var webStream = webResponse.GetResponseStream();

        using var alunos = new alunosAtivos(webStream);
        var data = new alunosAtivos();
        if (alunosAtivos contain turmaID != null) {
        Console.WriteLine(data);
    } else
{
    return NotFound();
}
    }
}
