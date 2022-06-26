using Microsoft.EntityFrameworkCore;

namespace GerenciamentoEscolaKensington.Model
{
    public class Alunos
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public int IDTurma { get; set; }
        public int TotalFaltas { get; set; }
    }
    public class AlunoDBContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
    }

    public class Aluno
    {
    }
}
