//Sistema de Gerenciamento de Escola

//Imagine que você está desenvolvendo um sistema de gerenciamento de escola.
//OK - Crie o cadastro do Aluno com caracteristicas como nome, idade, número de identificação do aluno (matrícula) e uma lista de cursos em que o aluno está matriculado.
//OK - Crie o cadastro de Professor com o nome, idade e um conjunto de disciplinas que o professor está lecionando. Permita que uma disciplina seja atribuída a um professor.
//OK - Abra a possibilidade que um aluno se matricule em um curso. Crie também uma forma de exibir a lista de cursos em que o aluno está matriculado.
//OK - Crie o cadastro de Curso com caracteristicas como nome, código do curso, os alunos matriculados no curso e as disciplinas deste curso. Deve-se permitir que um aluno seja
//OK - adicionado à lista de alunos do curso, assim como as disciplinas. Disponibilize a lista de alunos matriculados no curso. Disponibilize também a lista de disciplinas.
//OK - Crie o cadastro de Disciplinas com caracteristicas como titulo, carga horária e ementa. 
//OK - Disponibilize a lista de cursos + disciplinas que o professor está lecionando.
//OK - Gerenciar a atribuição de um aluno a um curso e vice-versa onde ambos serão atribuidos um ao outro portanto não deve ser possível adicionar um curso a um aluno sem
//OK - adicionar o aluno ao curso e vice-versa.
//OK - Comece pela criação do UML. Implemente todo o conteúdo aprendido no curso.
//Crie testes na main. Não é necessário criar um menu e sim objetos que acionem todas as classes e métodos criados em uma ordem lógica que faça sentido.

namespace Escola
{
    class Program
    {
        static void Main()
        {
            Curso engComp = new Curso("Engenharia de Computação", 1, null, null);
            Professor professor1 = new Professor("Cidão", 43, null);
            Disciplina mecSol = new Disciplina("Mecânica dos Sólidos", 60, "Análise de sistemas de forças atuantes sobre objetos.");
            Disciplina bancoDados1 = new Disciplina("Banco de Dados I", 80, "Estudo de sistemas de gerenciamento de dados");
            Disciplina estruturaDados1 = new Disciplina("Estrutura de Dados I", 60, "Criação de estruturas de controle e organização de dados em sistemas digitais.");

            
            Console.WriteLine("Fazendo atribuição de disciplinas sem a utilização do construtor\n");
            engComp.IncluirDisciplina(mecSol);
            professor1.AtribuirDisciplina(mecSol);
            engComp.IncluirDisciplina(estruturaDados1);


            Console.WriteLine("Testando atribuição de disciplinas no construtor\n");
            Professor professor2 = new Professor("Danilo", 43, estruturaDados1);


            Console.WriteLine("Instanciando aluno com definição de curso no construtor\n");
            Aluno aluno1 = new Aluno("Maurício Mafra", 26, engComp, 1);
            aluno1.Imprimir();


            Console.WriteLine("Criando uma aluna sem atribuir um curso no construtor\n");
            Aluno aluno2 = new Aluno("Bruna Oruchi", 24, null, 2);
            aluno2.Imprimir();

            Console.WriteLine("Verificando registro do curso antes de atribuir o mesmo à nova aluna\n");
            engComp.Imprimir();

            Console.WriteLine("Realizando matricula da nova aluna ao curso\n");
            aluno2.MatricularCurso(engComp);


            Console.WriteLine("Verificando alteração no curso\n");
            engComp.Imprimir();

            Console.WriteLine("Criando novo curso com atribuição de alunos e disciplinas no construtor\n");
            Curso engSoftware = new Curso("Engenharia de Software", 2, new List<Aluno>() { aluno1, aluno2 }, new List<Disciplina>(){ bancoDados1, estruturaDados1 });


            Console.WriteLine("Verificando a situação do novo curso após criação\n");
            engSoftware.Imprimir();

            Console.WriteLine("Verificando se o novo curso foi adicionado à lista de cursos dos alunos\n");
            aluno1.Imprimir();
            aluno2.Imprimir();

        }
    }
}