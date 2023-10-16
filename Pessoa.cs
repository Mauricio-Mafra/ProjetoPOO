namespace Escola
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }


        internal Pessoa(string nome, int idade) {
            Nome = nome; 
            Idade = idade;
        }


        /// <summary>
        /// Imprime dados da pessoa.
        /// </summary>
        public virtual void Imprimir()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
        }
    }
}
