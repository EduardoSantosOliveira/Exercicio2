using System;
using System.Globalization;
namespace Quarto_De_Aluguel
{


    class Principal
    {
        static void Main(string[] args)
        {

            //Armazena o tamanho do vetor em variavel
            Console.WriteLine("Digite a quantidade de quartos disponiveis: ");
            int Qtde_quartos = int.Parse(Console.ReadLine());


            //Declara e instacia o vetor do objeto " quarto " relacionadno a classe " Estudante "
            quarto[] quarto = new quarto[Qtde_quartos];
            Console.WriteLine();

            for (int i = 0; i < Qtde_quartos; i++)
            // inicia a " manipulação " ou navegação entre os 
            {
                Console.WriteLine("");
                Console.WriteLine("-----> DADOS DO HÓSPEDE: " + (i + 1));

                Console.WriteLine("Nome.....: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Idade.....: ");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Data de Nascimento.....: ");
                string dataNas = Console.ReadLine();

                Console.WriteLine("Numero.....: ");
                string numero = Console.ReadLine();

                Console.WriteLine("Endereço.....: ");
                string endereco = Console.ReadLine();

                Console.WriteLine("E-Mail.....: ");
                string email = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Qual vai ser o valor do aluguel: ");
                double valorAluguel = double.Parse(Console.ReadLine());

                Console.WriteLine("Quanto tempo o "+ nome + " vai alugar esse quarto: ");
                int tempoAluguel = int.Parse(Console.ReadLine());



                quarto[i] = new quarto(nome, endereco, email, idade, dataNas, numero, valorAluguel, tempoAluguel);
            }

            char adicionar;
            Console.WriteLine("Os clientes desejam imprimir os dados: [S]im ou [N]ão");
            adicionar = char.Parse(Console.ReadLine());

            if (adicionar == 's' || adicionar == 'S')
            {
                for (int i = 0; i < Qtde_quartos; i++)
                {
                    Console.WriteLine(quarto[i]);
                }
            }
            else
            {
                Console.WriteLine("Tudo bem não mostraremos os dados.");
            }

        }
    }
}

/*using System;
using System.Globalization;
namespace Quarto_De_Aluguel
{

    class Principal
    {
        static void Main(string[] args)
        {

            quarto A = new quarto();

            Console.WriteLine("BEM-VINDO AO NOSSO HOTEL!!!");
            Console.WriteLine("");
            Console.WriteLine("Quantos hospedes vao vir hoje? ");
            A.Hospede = int.Parse(Console.ReadLine());

            for (int i = 1; i <= A.Hospede; i++)
            {
                Console.WriteLine("");
                Console.Write("Qual o nome do " + i + " hospede ? ");
                A.Nome = Console.ReadLine();

                Console.Write("Qual a idade do " + A.Nome + " ? ");
                A.Idade = int.Parse(Console.ReadLine());

                Console.Write("Qual o endereço do " + A.Nome + " ? ");
                A.Endereço = Console.ReadLine();

                Console.Write("Qual a data de nascimento do " + A.Nome + " ? ");
                A.DataNas = Console.ReadLine();

                Console.Write("Qual o Email do " + A.Nome + " ? ");
                A.Email = Console.ReadLine();

                Console.Write("Qual o numero do " + A.Nome + " ? ");
                A.Numero = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("DADOS DO HOSPEDE " + i + ": " + A);
                Console.WriteLine("");


                Console.WriteLine("");
                Console.WriteLine("Qual o aluguel do quarto do " + A.Nome + " ? ");
                A.ValorAluguel = double.Parse(Console.ReadLine());

                Console.WriteLine("O " + A.Nome + " ira ficar quantos dias neste quarto ? ");
                A.TempoAluguel = int.Parse(Console.ReadLine());


                for (int Qtde = 1; Qtde <= i; Qtde++)
                    Console.WriteLine("");
                Console.WriteLine("DADOS DO ALUGUEL DO " + i + " QUARTO: " + A
                + "\n\nO valor do quarto por dia: R$ "
                + A.ValorAluguel.ToString("F2")
                + "\nO tempo do aluguel: "
                + A.TempoAluguel
                + " dias "
                + "\nO valor total do aluguel: R$ "
                + A.ValorTotal());
            }
        }
    }
}*/