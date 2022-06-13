using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    class dadosDoProduto
    {
        public string Nome;
        public double Preco;
        public int QtdeProduto;
        public int QtdeProdutoA;
        public int QtdeProdutoR;


        public override string ToString()
        {
            return "Nome do Produto: " + Nome +
            " preço atual do produto: " + (QtdeProduto * Preco) +
            " quantidade atualizada do produto: " + (QtdeProduto);
        }

    }
}
