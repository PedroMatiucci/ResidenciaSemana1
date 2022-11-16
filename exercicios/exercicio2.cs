namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertice teste = new Vertice(5, 10);
            Console.WriteLine(teste.distancia());
            Console.ReadKey();
            teste.move(3, 2);
            Console.WriteLine(teste.distancia());
            Console.WriteLine(teste.iguais());
            teste.move(2, 2);
            Console.WriteLine(teste.iguais());
            Console.ReadKey();
        }
    }


    public class Vertice
    {
        private int x;
        private int y;

        public Vertice(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X { get { return x; } }
        public int Y { get { return y; } }

        public double distancia()
        {
            int sum = 0;
            for (int i = 0; i < x + 1; i++)
            {
                int d = x - y;
                sum = sum + d * d;
            }
            return Math.Sqrt(sum);
        }

        public void move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool iguais()
        {
            return x == y;
        }


    }
}