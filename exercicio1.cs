using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Encodings.Web;

namespace exercicio1
{
	class Program
	{
		static void Main(string[] args)
		{
			Piramide teste = new Piramide(5);
            teste.desenha(teste.Tamanho);
			Console.ReadKey();
        }
    }

	public class Piramide 
	{
		private int tamanho;

		public Piramide(int tamanho)
		{
			this.tamanho = tamanho;
		}

		public int Tamanho { get { return tamanho; } }

		public void desenha(int tamanho)
		{
            for (int numero_linhas = 0; numero_linhas < tamanho + 1;numero_linhas++)
			{
				int x = 1;
                for ( int j = 1; j < numero_linhas * 2; j++)
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