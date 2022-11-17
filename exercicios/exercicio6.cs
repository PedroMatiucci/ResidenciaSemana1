using exercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidenciaSoftware.exercicios
{
    internal class ListaIntervalos
    {
        private SortedList<DateTime, Intervalo> listaIntevalo = new SortedList<DateTime, Intervalo>();

        public SortedList<DateTime, Intervalo> ListaIntervalo
        {
            get { return listaIntevalo; }
            private set { }

        }

        public void Add(Intervalo novoIntervalo)
        {
            if (ListaIntervalo.ContainsValue(novoIntervalo))
            {
                throw new InvalidNumberException("Intervalo ja esta na lista");
            }
            else
            {
                ListaIntervalo.Add(novoIntervalo.Inicio, novoIntervalo);
            }
        }

        public void Print()
        {
            for (int i = 0; i < ListaIntervalo.Count; i++)
            {
                Console.Write(ListaIntervalo.Values[i].Inicio);
                Console.Write(" ");
                Console.Write(ListaIntervalo.Values[i].Final);
                Console.WriteLine(" ");
            }
        }
    }
}
