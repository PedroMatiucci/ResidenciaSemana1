using exercicio2;
using exercicio3;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Piramide teste = new Piramide(2);
            // teste.desenha(teste.Tamanho);
            // Console.ReadKey();
            Vertice a = new Vertice(0, 0);
            Vertice b= new Vertice(0, 4);
            Vertice c = new Vertice(2, 2);
            Triangulo tri = new Triangulo(a, b, c);
            Triangulo tri2 = new Triangulo(b, a, c);
            tri.Iguais(tri, tri2);
        }
    }

    public class Piramide
    {
        private int tamanho;

        public Piramide(int tamanho)
        {
            try
            {
                if (tamanho < 0) {
                    throw new InvalidNumberException("Por favor insira um numero maior que zero");
                }
                else {
                    this.tamanho = tamanho;
                }
            }
            catch(InvalidNumberException e) { Console.WriteLine(e); }
            {

            }
        }

        public int Tamanho { get { return tamanho; } }

        public void desenha(int tamanho)
        {
            for (int numero_linhas = 0; numero_linhas < tamanho + 1; numero_linhas++)
            {
                int x = 1;
                for (int j = 1; j < numero_linhas * 2; j++)
                {
                    if (j > numero_linhas)
                    {
                        Console.Write(numero_linhas - x);
                        x++;
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine(" ");
                Console.ReadKey();

            }
            Console.ReadKey();
        }
    }
}
public class InvalidNumberException : Exception
{
    public InvalidNumberException(String message)
        : base(message)
    {

    }
}