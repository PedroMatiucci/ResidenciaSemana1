using exercicio1;

namespace ResidenciaSoftware.exercicios
{
    internal class Intervalo
    {
        private DateTime inicio;
        private DateTime final;
        private TimeSpan duracao;

        public Intervalo(DateTime inicio, DateTime final)
        {
            this.inicio = inicio;
            this.final = final;
            if (Inicio < Final)
            {
                throw new InvalidNumberExeption("Data Final Maior Do Que A Inicial");
            }
        }

        public DateTime Inicio
        {
            get { return inicio; }
            private set { }
        }
        public DateTime Final
        {
            get { return final; }
            private set
            { }
        }

        public TimeSpan Duracao
        {
            get { return duracao; }
            private set
            {
                duracao = Final - Inicio;
            }
        }

        public bool TemIntersecao(Intervalo novoIntervalo)
        {
            return (this.Inicio <= novoIntervalo.Final) && (novoIntervalo.Inicio <= this.Final);
        }

        public override bool Equals(object? obj)
        {
            return obj is Intervalo intervalo &&
                this.Inicio == intervalo.Inicio &&
                this.Final == intervalo.Final;

        }
    }
}
