namespace Escola
{
    internal class Professor : Pessoa
    {
        private List<Disciplina> Disciplinas { get; set; }

        internal Professor(string nome, int idade, Disciplina? disciplina) : base (nome, idade)
        {
            Disciplinas = new List<Disciplina>();
            if (disciplina is not null) 
            {
                AtribuirDisciplina(disciplina);
            }
        }


        /// <summary>
        /// Imprime dados do professor.
        /// </summary>
        public override void Imprimir()
        {
            string disciplinasProfessor = "";


            foreach(Disciplina disciplina in Disciplinas)
            {
                disciplinasProfessor += "\t- ";
                disciplinasProfessor += disciplina.Nome;
                disciplinasProfessor += "\n";
            }

            Console.WriteLine("\n PROFESSOR");
            base.Imprimir();
            Console.WriteLine($"Disciplinas lecionadas:");
            Console.WriteLine($"{disciplinasProfessor}");
        }

        public void AtribuirDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add( disciplina );
        }

    }
}
