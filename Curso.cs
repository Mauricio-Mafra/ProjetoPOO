namespace Escola
{
    internal class Curso
    {
        public string Nome {  get; set; }
        public int Codigo { get; set; }
        public List<Aluno> Alunos { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

        internal Curso(string nome, int codigo, List<Aluno>? alunos, List<Disciplina>? disciplinas)
        {
            Nome = nome;
            Codigo = codigo;
            Alunos = new List<Aluno>();
            Disciplinas = new List<Disciplina>();

            if (alunos is not null)
            {
                foreach (Aluno aluno in alunos)
                    aluno.MatricularCurso(this);
            }

            if (disciplinas is not null)
            {
                Disciplinas = disciplinas;
            }
        }


        /// <summary>
        /// Imprime dados do curso com a lista de alunos e disciplinas que fazem parte do mesmo.
        /// </summary>
        public void Imprimir()
        {

            string alunosCurso = "";
            string disciplinasCurso = "";

            foreach (Aluno aluno in Alunos)
            {
                alunosCurso += "\t- ";
                alunosCurso += aluno.Nome;
                alunosCurso += "\n";

            }

            foreach (Disciplina disciplina in Disciplinas)
            {
                disciplinasCurso += "\t- ";
                disciplinasCurso += disciplina.Nome;
                disciplinasCurso += "\n";
            }

            Console.WriteLine("\nCURSO");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Código: {Codigo} horas");
            Console.WriteLine($"Alunos:");
            Console.WriteLine($"{alunosCurso}");
            Console.WriteLine($"Disciplinas:");
            Console.WriteLine($"{disciplinasCurso}");
        }


        /// <summary>
        /// Realiza a inclusão de um aluno em um curso.
        /// </summary>
        /// <param name="aluno"></param>
        public void IncluirAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
            Console.WriteLine($"O aluno {aluno.Nome} foi matriculado no curso {Nome}");
        }

        /// <summary>
        /// Realiza a inclusão de uma disciplina em um curso.
        /// </summary>
        /// <param name="disciplina"></param>
        public void IncluirDisciplina(Disciplina disciplina) 
        {
            Console.WriteLine($"Incluindo a disciplina {disciplina.Nome} no curso {Nome}");
            Disciplinas.Add( disciplina );
            Console.WriteLine("Disciplina adicionada!");
        }



    }
}
