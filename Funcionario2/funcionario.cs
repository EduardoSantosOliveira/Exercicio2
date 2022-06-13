using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_Funcionarios
{
     class funcionario
    {
        public string Nome;
        public double SalarioB;
        public double Imposto;
        public char adicionar;

        public double SalarioLiq()
        {
            return(SalarioB - Imposto);    
        }
        public void AumentoSal(double perct_Aumento)
        {
            SalarioB = SalarioB + (SalarioB * perct_Aumento / 100);
        }

        public override string ToString()
        {
            return "\nNome do funcionario: " 
                + Nome.ToUpper()
                +"\nSalario Bruto: R$"
                +SalarioB.ToString("F2")
                +"\nImposto: R$"
                +Imposto.ToString("F2")
                + "\nRecebe por mês: R$" 
                + SalarioLiq().ToString("F2");
        }
    }
}
