using exercicio1;
using exercicio2;

namespace exercicio3
{
    public class Triangulo
    {
        private Vertice a;
        private Vertice b;
        private Vertice c;
        public double perimetro;
        public double area;
        public Triangulo(Vertice a, Vertice b, Vertice c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Vertice A
        {
            get { return a; }
            private set
            {
                if (VerificaTriangulo())
                {
                    a = value;
                }
                else
                {
                    throw new ImpossibleTriangleExeption("Este Triangulo e Impossivel");
                }
            }
        }
        public Vertice B
        {
            get { return b; }
            private set
            {
                if (VerificaTriangulo())
                {
                    b = value;
                }
                else
                {
                    throw new ImpossibleTriangleExeption("Este Triangulo e Impossivel");
                }
            }
        }
        public Vertice C
        {
            get { return c; }
            private set
            {
                if (VerificaTriangulo())
                {
                    c = value;
                }
                else
                {
                    throw new ImpossibleTriangleExeption("Este Triangulo e Impossivel");
                }
            }
        }
        public double Perimetro
        {
            get
            {
                return perimetro;
            }
            set { perimetro = A.Distancia(B) + B.Distancia(C) + C.Distancia(A); }
        }
        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                double s = Perimetro / 2;
                area = Math.Sqrt(s * (s - A.Distancia(B)) * (s - B.Distancia(C)) * (s - C.Distancia(A)));
            }
        }



        public override bool Equals(object? obj)
        {
            return obj is Triangulo triangulo &&
            this.A.Distancia(this.B) == triangulo.A.Distancia(triangulo.B) &&
            this.A.Distancia(this.B) == triangulo.A.Distancia(triangulo.C) &&
            this.A.Distancia(this.B) == triangulo.B.Distancia(triangulo.C) &&
            this.B.Distancia(this.C) == triangulo.A.Distancia(triangulo.B) &&
            this.B.Distancia(this.C) == triangulo.A.Distancia(triangulo.C) &&
            this.B.Distancia(this.C) == triangulo.C.Distancia(triangulo.B) &&
            this.C.Distancia(this.A) == triangulo.A.Distancia(triangulo.B) &&
            this.C.Distancia(this.A) == triangulo.B.Distancia(triangulo.C) &&
            this.C.Distancia(this.A) == triangulo.C.Distancia(triangulo.A);
        }

        private bool VerificaTriangulo()
        {
            double maior_lado = 0;
            double soma_menores = 0;
            if (A.Distancia(B) == B.Distancia(C) && B.Distancia(C) == C.Distancia(A))
            {
                return true;
            }
            else if (A.Distancia(B) > B.Distancia(C) && A.Distancia(B) > C.Distancia(A))
            {
                maior_lado = A.Distancia(B);
                soma_menores = A.Distancia(C) + B.Distancia(C);
            }
            else if (B.Distancia(C) > C.Distancia(A))
            {
                maior_lado = B.Distancia(C);
                soma_menores += C.Distancia(A) + A.Distancia(B);
            }
            else
            {
                maior_lado = C.Distancia(A);
                soma_menores += C.Distancia(B) + A.Distancia(B);
            }
            return maior_lado > soma_menores;
        }
    }


}

