using System;
using System.Globalization;
namespace ControleDeEstoque
{

    class Principal
    {
        static void Main(string[] args)
        {
            dadosDoProduto A;
            A = new dadosDoProduto();
            char escolha;
            char adicionar;
         

            Console.WriteLine("qual o nome do produto que voce deseja listar ? ");
            A.Nome = Console.ReadLine();

            Console.WriteLine("qual o preço desse produto ? ");
            A.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("qual a quantidade do produto ? ");
            A.QtdeProduto = int.Parse(Console.ReadLine());

            /*Console.WriteLine("******lista atual: **********");
            Console.WriteLine("Nome do Produto: " + A.Nome);
            Console.WriteLine("preço atual do produto: " + A.QtdeProduto * A.Preco);
            Console.WriteLine("quantidade atualizada do produto: " + (A.QtdeProduto));*/
            Console.WriteLine(" Lista Atual " + A);


            do
            {

                Console.WriteLine("");
                Console.WriteLine("voce deseja ajustar o estoque do prouto ? <s = sim  || n = não>");
                escolha = char.Parse(Console.ReadLine());

                if (escolha == 'n' || escolha == 'N')
                {
                    Console.WriteLine("tudo bem nao iremos ajustar o valor do estoque.");
                    Console.WriteLine("");
                    Console.WriteLine("******lista atual: **********");
                    Console.WriteLine("Nome do Produto: " + A.Nome);
                    Console.WriteLine("preço atual do produto: " + A.QtdeProduto * A.Preco);
                    Console.WriteLine("quantidade atualizada do produto: " + A.QtdeProduto);

                    break;

                }

                Console.WriteLine("voce deseja aumentar ou reduzir o estoque do prouto ? <a = aumenta  || r = reduzir>");
                adicionar = char.Parse(Console.ReadLine());


                if (escolha == 's' && adicionar == 'a' || escolha == 'S' && adicionar == 'A')
                {
                    Console.WriteLine("qual o valor que voce ira adicionar ao estoque ? ");
                    A.QtdeProdutoA = int.Parse(Console.ReadLine());
                    A.QtdeProduto = A.QtdeProduto + A.QtdeProdutoA;


                    Console.WriteLine("essa é o novo valor da quantidade de produtos: " + (A.QtdeProduto));
                    Console.WriteLine("");
                    Console.WriteLine("******lista atualizada: **********");
                    Console.WriteLine("Nome do Produto: " + A.Nome);
                    Console.WriteLine("preço atual do produto: " + A.QtdeProduto * A.Preco);
                    Console.WriteLine("quantidade atualizada do produto: " + (A.QtdeProduto));

                }

                if (escolha == 's' && adicionar == 'r' || escolha == 'S' && adicionar == 'R')
                {
                    Console.WriteLine("qual o valor que voce ira redizuir ao estoque ? ");
                    A.QtdeProdutoR = int.Parse(Console.ReadLine());
                    A.QtdeProduto =  (A.QtdeProduto - A.QtdeProdutoR);

                    Console.WriteLine("essa é o novo valor da quantidade de produtos: " + (A.QtdeProduto));
                    Console.WriteLine("");
                    Console.WriteLine("******lista atualizada: **********");
                    Console.WriteLine("Nome do Produto: " + A.Nome);
                    Console.WriteLine("preço atual do produto: " + A.QtdeProduto * A.Preco);
                    Console.WriteLine("quantidade atualizada do produto: " + (A.QtdeProduto));
                }

            } while (escolha == 's');
            

        }
    }
}
