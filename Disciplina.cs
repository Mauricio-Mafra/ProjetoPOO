namespace Escola
{
    internal class Disciplina
    {
        public string Nome {  get; private set; }

        private int cargaHoraria;
        private int CargaHoraria {
            get => cargaHoraria;

            set { 
                if (value < 0)
                {
                    Console.WriteLine("A carga horária deve ser maior que 0");
                    cargaHoraria = 1;
                    return;
                }
                cargaHoraria = value;
            } 
        }

        private string ementa;
        private string Ementa { 
            get => ementa;
            
            set { 
                if (value == "")
                {
                    Console.WriteLine("Inclua a ementa da disciplina.");
                    ementa = "";
                    return;
                }
                ementa = value;
            } 
        }
        internal Disciplina(string nome, int cargaHoraria, string ementa) {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            Ementa = ementa;
        }
        /// <summary>
        /// Permite atualização da ementa de uma disciplina
        /// </summary>
        /// <param name="novaEmenta"></param>
        public void AtualizarEmenta(string novaEmenta)
        {
            Ementa = novaEmenta;
        }
        /// <summary>
        /// Permite a atualização da carga horária de uma disciplina
        /// </summary>
        /// <param name="novaCargaHoraria"></param>
        public void AtualizarCargaHoraria(int novaCargaHoraria)
        {
            CargaHoraria = novaCargaHoraria;
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
