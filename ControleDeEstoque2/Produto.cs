using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque2
{
     class Produto
    {
        public string Nome; public double Preco; public int Quantidade;

        public double ValorTotalEstoque()
        {
            double vlr_Total = Preco * Quantidade;
            return vlr_Total;
        }
        public void AumentoEstoque(int qtd_ajustada)
        {
            Quantidade += qtd_ajustada; 
        }
        public void ReduzirEstoque(int qtd_ajustada)
        {
            Quantidade -= qtd_ajustada;
        }
        public override string ToString()
        {
            return "O produto"
                +Nome.ToUpper()
        }
    }
}
