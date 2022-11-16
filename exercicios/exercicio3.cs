using exercicio2;

namespace exercicio3
{
    internal class exercicio3
    {

    }

    public class Triangulo
    {
        private Vertice a;
        private Vertice b;
        private Vertice c;
        public double perimetro;
        public double area;
        enum Tipo { Isoceles, Escaleno, Equilatero };
        public Triangulo(Vertice a, Vertice b, Vertice c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Vertice A { get { return a; } }
        public Vertice B { get { return b; } }
        public Vertice C { get { return c; } }
        public double Perimetro
        {
            get
            {
                return perimetro;
            }
            set { perimetro = A.distancia() + B.distancia() + C.distancia(); }
        }
        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                double s = perimetro / 2;
                area = Math.Sqrt(s * (s - A.distancia()) * (s - B.distancia()) * (s - C.distancia()));
            }
        }



        public bool Iguais(dynamic triangulo1, dynamic triangulo2)
        {
            if (triangulo1.A == triangulo2.A & triangulo1.B == triangulo2.B & triangulo1.C == triangulo2.C)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }


}


