namespace exercicio1
{

    public class Piramide
    {
        private int tamanho;

        public Piramide(int tamanho)
        {
            this.tamanho = tamanho;
        }

        public int Tamanho
        {
            get { return tamanho; }
            set
            {
                if (value <= 0)
                    throw new InvalidNumberException("O tamanho deve ser maior que zero");
                tamanho = value;
            }
        }

        public void Desenha()
        {
            for (int numero_linhas = 0; numero_linhas <= tamanho; numero_linhas++)
            {
                for (int j = 0; j < tamanho - 1; j++)
                    Console.Write(" ");

                for (int j = 1; j <= numero_linhas; j++)
                    Console.Write(j);

                for (int j = numero_linhas - 1; j >= 1; j--)
                    Console.Write(j);

                Console.WriteLine();

            }

        }
    }
}

    
