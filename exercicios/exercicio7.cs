using System.Globalization;
using System.Text.RegularExpressions;

namespace ResidenciaSoftware.exercicios
{
    internal class ControladorCliente
    {
        private string nome;
        private long cpf;
        private DateTime dataDeNascimento;
        private float rendaMensal;
        private char estadoCivil;
        private int dependentes;


        public void Cadastrar()
        {
            nome = CadastrarNome();
            cpf = CadastrarCpf();
            dataDeNascimento = CadastrarDataNascimento();
            rendaMensal = CadastrarRenda();
            estadoCivil = CadastrarEstado();
            dependentes = CadastrarDependentes();
            Cliente novoCliente = new Cliente(nome, cpf, dataDeNascimento, rendaMensal, estadoCivil, dependentes);
        }

        private string CadastrarNome()
        {

            Console.WriteLine("Digite Seu Nome:");
            string novoNome = Console.ReadLine();
            while (novoNome.Length < 5)
            {
                Console.WriteLine("Seu Nome Tem Que Conter Pelo Menos 5 Caracteres");
                Console.WriteLine("Digite Seu Nome:");
                novoNome = Console.ReadLine();
            }
            Console.WriteLine("Sucesso");
            return novoNome;
        }

        private long CadastrarCpf()
        {
            string pattern = @"^\d{11}$";
            Regex rg = new Regex(pattern);
            Console.WriteLine("Digite Seu CPF:");
            string novoCpf = Console.ReadLine();
            Match m = rg.Match(novoCpf);
            while (m.Success == false)
            {
                Console.WriteLine("Por Favor Digite um Cpf Valido");
                Console.WriteLine("Digite Seu CPF:");
                novoCpf = Console.ReadLine();
                m = rg.Match(novoCpf);

            }
            Console.WriteLine("Sucesso");
            return long.Parse(novoCpf);
        }

        private DateTime CadastrarDataNascimento()
        {
            string pattern = @"^\d{2}\/\d{2}\/\d{4}$";
            Regex rg = new Regex(pattern);
            Console.WriteLine("Escreva Sua Data De Nascimento:");
            string novaData = Console.ReadLine();
            Match m1 = rg.Match(novaData);
            while (true)
            {
                if (m1.Success == false)
                {
                    Console.WriteLine("Por Favor Digite uma Data Valida");
                    Console.WriteLine("Escreva Sua Data De Nascimento:");
                    novaData = Console.ReadLine();
                    m1 = rg.Match(novaData);
                }
                else
                {
                    DateTime dt = DateTime.Now;
                    try
                    {
                        dt = DateTime.ParseExact(novaData, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Por Favor Digite uma Data Valida");
                        CadastrarDataNascimento();

                    }
                    int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                    int dob = int.Parse(dt.ToString("yyyyMMdd"));
                    int age = (now - dob) / 10000;
                    if (age >= 18)
                    {
                        return dt;
                    }
                    else
                    {
                        CadastrarDataNascimento();
                    }
                }
            }
        }

        private float CadastrarRenda()
        {
            string pattern = @"^\d+,\d{2}$";
            Regex rg = new Regex(pattern);
            Console.WriteLine("Digite sua Renda Mensal:");
            string novaRenda = Console.ReadLine();
            Match m = rg.Match(novaRenda);
            while (m.Success == false)
            {
                Console.WriteLine("Por Favor Digite Uma Renda Valida");
                Console.WriteLine("Digite sua Renda Mensal:");
                novaRenda = Console.ReadLine();
                m = rg.Match(novaRenda);
            }
            Console.WriteLine("Sucesso");
            return float.Parse(novaRenda);
        }

        private char CadastrarEstado()
        {
            string pattern = @"^[CSVD]$";
            Regex rg = new Regex(pattern);
            Console.WriteLine("C - Casado, S- Solteiro, V - Viuvo, D - Divorciado");
            Console.WriteLine("Digite Seu estado Civil");
            string novoEstado = Console.ReadLine();
            Match m = rg.Match(novoEstado);
            while (m.Success == false)
            {
                Console.WriteLine("Por Favor Digite Um Estado Valido");
                Console.WriteLine("C - Casado, S- Solteiro, V - Viuvo, D - Divorciado");
                Console.WriteLine("Digite Seu estado Civil");
                novoEstado = Console.ReadLine();
                m = rg.Match(novoEstado);
            }
            Console.WriteLine("Sucesso");
            return char.Parse(novoEstado);
        }

        private int CadastrarDependentes()
        {
            string pattern = @"\b([1-9]|10)\b";
            Regex rg = new Regex(pattern);
            Console.WriteLine("Digite O Numero de Dependentes");
            string novoDependente = Console.ReadLine();
            Match m = rg.Match(novoDependente);
            while (m.Success == false)
            {
                Console.WriteLine("Por Favor Digite Um Estado Valido");
                Console.WriteLine("Digite O Numero de Dependentes");
                novoDependente = Console.ReadLine();
                m = rg.Match(novoDependente);
            }
            Console.WriteLine("Sucesso");
            return int.Parse(novoDependente);
        }
    }
}

internal class Cliente
{
    private string nome;
    private long cpf;
    private DateTime dataDeNascimento;
    private float rendaMensal;
    private char estadoCivil;
    private int dependentes;
    public Cliente(string nome, long cpf, DateTime dataDeNascimento, float rendaMensal, char estadoCivil, int dependentes)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.dataDeNascimento = dataDeNascimento;
        this.rendaMensal = rendaMensal;
        this.estadoCivil = estadoCivil;
        this.dependentes = dependentes;
    }

    public string Nome { get { return nome; } private set { } }

    public long Cpf { get { return cpf; } private set { } }

    public DateTime DataDeNascimento { get { return dataDeNascimento; } private set { } }

    public float RendaMensal { get { return rendaMensal; } private set { } }

    public char EstadoCivil { get { return estadoCivil; } private set { } }

    public int Dependentes { get { return dependentes; } private set { } }
}

