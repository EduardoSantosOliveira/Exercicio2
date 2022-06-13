using System;
using System.Globalization;
namespace QuartoComVetor
{

    class Principal
    {
        static void Main(string[] args)
        {
            //Armazena o tamanho do vetor em variavel
            Console.WriteLine("Digite a quantidade de quartos disponiveis: ");
            int Qtde_quartos = int.Parse(Console.ReadLine());


            //Declara e instacia o vetor do objeto " quarto " relacionadno a classe " Estudante "
            Estudante[] quarto = new Estudante[Qtde_quartos];
            Console.WriteLine();

            for(int i = 0; i < Qtde_quartos; i++)
             // inicia a " manipulação " ou navegação entre os 
            {
                Console.WriteLine("");
                Console.WriteLine("-----> DADOS DO HÓSPEDE: " + (i + 1));
                Console.WriteLine("Nome.....: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Endereço.....: ");
                string Endereco = Console.ReadLine();

                Console.WriteLine("E-Mail.....: ");
                string Email = Console.ReadLine();

                quarto[i] = new Estudante(nome, Endereco, Email);
            }

            for(int i = 0; i < Qtde_quartos; i++)
            {
                Console.WriteLine(quarto[i]);
            }

        }
    }
}