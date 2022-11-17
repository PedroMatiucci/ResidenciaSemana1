namespace exercicio2
{

    public class Vertice
    {
        private int x;
        private int y;

        public Vertice(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X { get { return x; } private set { } }
        public int Y { get { return y; } private set { } }

        public double Distancia(Vertice outro)
        {
            double distancia_x = (this.X - outro.X) * (this.X - outro.X);
            double distancia_y = (this.Y - outro.Y) * (this.Y - outro.Y);

            return Math.Sqrt(distancia_x + distancia_y);
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object? obj)
        {
            return obj is Vertice vertice &&
                this.X == vertice.X &&
                this.Y == vertice.Y;

        }


    }
}