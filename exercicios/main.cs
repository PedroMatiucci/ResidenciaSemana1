using exercicio1;
using exercicio2;
using exercicio3;
using ResidenciaSoftware.exercicios;

namespace main
{
    class Program
    {

        static void Main(string[] args)
        {
            DateTime inicio1 = new DateTime(2015, 12, 23);
            DateTime final1 = new DateTime(2016,12, 23);
            DateTime inicio2 = new DateTime(2015, 8, 23);
            DateTime final2 = new DateTime(2016, 12, 23);
            Intervalo teste = new Intervalo(inicio1,final1);
            Intervalo teste2 = new Intervalo(inicio2, final2);
            ListaIntervalos lista = new ListaIntervalos();
            lista.Add(teste);
            lista.Add(teste2);
            lista.Print();

        }
    }
}
