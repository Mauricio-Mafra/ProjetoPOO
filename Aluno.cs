namespace Escola
{
    internal class Aluno : Pessoa
    {
        private List<Curso> Cursos { get; set; } = new List<Curso>();

        private int matricula;
        public int Matricula { 
            get => matricula;

            private set { 
                if (value < 0) {
                    Console.WriteLine("Valor da matrícula deve ser maior que 0.");
                    matricula = -1 * value;
                    return;
                }

                matricula = value;
            } }

        internal Aluno(string nome, int idade, Curso? curso, int matricula) :base (nome, idade)
        {
            Cursos = new List<Curso>();
            
            if (curso is not null) 
                MatricularCurso(curso);
            

            Matricula = matricula;
        }


        /// <summary>
        /// Imprime dados do aluno.
        /// </summary>
        public override void Imprimir()
        {

            string cursosAluno = "";
            foreach (Curso curso in Cursos)
            {
                cursosAluno += "\t- ";
                cursosAluno += curso.Nome;
                cursosAluno += "\n";
            }

            Console.WriteLine("\nALUNO");
            base.Imprimir();
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Cursos:");
            Console.WriteLine($"{cursosAluno}");
        }

        /// <summary>
        /// Realiza a matrícula de um aluno em um determinado curso, adicionando o mesmo na lista de alunos do curso.
        /// </summary>
        /// <param name="curso"></param>
        public void MatricularCurso(Curso curso)
        {
            Cursos.Add( curso );
            Console.WriteLine($"\nO aluno {Nome} foi matriculado no curso {curso.Nome} com sucesso!");
            curso.IncluirAluno(this);

        }

    }
}
