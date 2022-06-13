using System;
using System.Globalization;
namespace dados_Funcionarios
{

    class Principal
    {
        static void Main(string[] args)
        {
            funcionario A = new funcionario();

            Console.Write("Nome do Funcionario: ");
            A.Nome = Console.ReadLine();

            Console.Write("Salario Bruto do Funcionario: ");
            A.SalarioB = double.Parse(Console.ReadLine());

            Console.Write("Digite o imposto: ");
            A.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("RELATORIO: " + A);
           

            Console.WriteLine("Deseja aumentar o salario do funcionario ? [S]im ou [N]ão");
            A.adicionar = char.Parse(Console.ReadLine());

            if(A.adicionar == 's' || A.adicionar == 'S')
            {
                Console.WriteLine("quantos % voce quer aumentar: ");
                double percent_Aumento = double.Parse(Console.ReadLine());
                A.AumentoSal(percent_Aumento);

                Console.WriteLine("");
                Console.WriteLine("RELATORIO: " + A);
              
            }
            else
            {
                Console.WriteLine("tudo bem nao iremos aumentar o salario.");
                Console.WriteLine("");
                Console.WriteLine("RELATORIO: " + A);
                Console.WriteLine("");
            }
        }
    }
}
