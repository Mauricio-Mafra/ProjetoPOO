namespace Escola
{
    internal class Disciplina
    {
        public string Nome {  get; set; }
        public int CargaHoraria { get; set; }
        public string Ementa { get; set; }
        internal Disciplina(string nome, int cargaHoraria, string ementa) {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            Ementa = ementa;
        }

        /// <summary>
        /// Imprime dados da disciplina.
        /// </summary>
        public void Imprimir()
        {
            Console.WriteLine("\nDISCIPLINA");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Carga horária: {CargaHoraria} horas");
            Console.WriteLine($"Ementa: {Ementa}");
        }
    }
}
