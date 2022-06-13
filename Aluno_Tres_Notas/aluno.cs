using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoTresNotas
{
     class aluno
    {
        public string nomeAluno;
        public double nota1;
        public double nota2;
        public double nota3;
        public double Soma()
        {
            double soma = (nota1 + nota2 + nota3);
            return soma;
        }
    }
}
