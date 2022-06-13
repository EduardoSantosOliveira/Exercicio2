using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarto_De_Aluguel
{
    class quarto
    {

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public string DataNas { get; set; }
        public string Numero { get; set; }


        public double ValorAluguel { get; set; }
        public int TempoAluguel { get; set; }


        public quarto(string nome, string endereco, string email, int idade, string dataNas,  string numero, double valorAluguel, int tempoAluguel )
        {
            Nome = nome;
            Idade = idade;
            DataNas = dataNas;
            Numero = numero;
            Endereco = endereco;
            Email = email;
            ValorAluguel = valorAluguel;
            TempoAluguel = tempoAluguel;

            
        }
        public double CalculoAluguel()
        {
            return ValorAluguel * TempoAluguel;
        }

        public override string ToString()
        {
            return "\nNome: "
                + Nome
                + "\nIdade: "
                + Idade
                + "\nData de Nascimento: "
                + DataNas
                + "\nNúmero:  "
                + Numero
                + "\nEndereço: "
                + Endereco
                + "\nE-Mail: "
                + Email
                + "\nValor Total do aluguel: R$"
                + CalculoAluguel();
                
                
        }
    }
}

/*namespace Quarto_De_Aluguel
{
    class quarto
    {
        public int Hospede;
        public double ValorAluguel;
        public int TempoAluguel;

        public string Nome;
        public int Idade;
        public string Endereço;
        public string DataNas;
        public string Email;
        public string Numero;

        public double ValorTotal()
        {
            return ValorAluguel * TempoAluguel;

        }

        public override string ToString()
        {
            return "\nNome: "
                + Nome.ToUpper()
                + "\nIdade: "
                + Idade
                + "\nEndereço: "
                + Endereço
                + "\nData de Nascimento: "
                + DataNas
                + "\nEmail: "
                + Email
                + "\nNumero: "
                + Numero;

        }
    }
}*/


