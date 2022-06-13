using System;
using System.Globalization;
namespace AlunoTresNotas
{

    class Programa
    {
        static void Main(string[] args)
        {
            aluno A;
            A = new aluno();

            Console.WriteLine("qual o nome do aluno? ");
            A.nomeAluno = Console.ReadLine();

            Console.WriteLine("digite as tres notas do aluno " + A.nomeAluno);
            Console.WriteLine("");
            Console.WriteLine("digite a primeira nota: ");
            A.nota1 = double.Parse(Console.ReadLine());
            if(A.nota1 > 30)
            {
                while (A.nota1 > 30)
                {
                    Console.WriteLine("a nota é de no maximo 30 digite novamente");
                    A.nota1 = double.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("digite a segunda nota: ");
            A.nota2 = double.Parse(Console.ReadLine());
            if (A.nota2 > 35)
            {
                while (A.nota2 > 35)
                {
                    Console.WriteLine("a nota é de no maximo 35 digite novamente");
                    A.nota2 = double.Parse(Console.ReadLine());
                   
                }
            }
            Console.WriteLine("digite a terceira nota: ");
            A.nota3 = double.Parse(Console.ReadLine());
            if (A.nota3 > 35)
            {
                while (A.nota3 > 35)
                {
                    Console.WriteLine("a nota é de no maximo 35 digite novamente");
                    A.nota3 = double.Parse(Console.ReadLine());
                }
            }
            /*A.Soma();
            Console.WriteLine("NOTA FINAL: " + A.Soma());
            if(A.Soma() > 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM: " + (60 - A.Soma()));
            }*/
            Console.WriteLine(A.Soma() > 60 ? "Aprovado" : "REPROVADO\nFALTARAM: " + (60 - A.Soma()) + " PONTOS");

            }

        }
    }

    