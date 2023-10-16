namespace Escola
{
    internal class Disciplina
    {
        public string Nome {  get; set; }

        private int cargaHoraria;
        public int CargaHoraria {
            get => cargaHoraria;

            private set { 
                if (value < 0)
                {
                    Console.WriteLine("A carga horária deve ser maior que 0");
                    return;
                }
                cargaHoraria = value;
            } 
        }

        private string ementa;
        public string Ementa { 
            get => ementa;
            
            private set { 
                if (value == "")
                {
                    Console.WriteLine("Inclua a ementa da disciplina.");
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
