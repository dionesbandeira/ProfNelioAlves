using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves {
    internal class ContaBancaria {

        //encapsulando os atributos e tornando-as propriedades 
        //Aqui estou encapsulando para nao permitir que desenvolvedores acesse ou altere na mao
        public string NomeTitular { get; set; }
        public int NumeroConta { get; private set; }
        public double SaldoConta { get; set; }

        //Construtores com carga e sobrecarga
        public ContaBancaria(string nomeTitular, int numeroConta) {
            NomeTitular = nomeTitular;
            NumeroConta = numeroConta;
        }
        // : this reaproveitando variaveis do construtor  
        public ContaBancaria(string nomeTitular, int numeroConta, double saldoConta) : this(nomeTitular, numeroConta) {
            SaldoConta = saldoConta;
        }


        public void Depositar(double quantia) {
            SaldoConta += quantia;
        }
        public void Sacar(double quantia) {
            SaldoConta -= quantia;
            SaldoConta -= 5.0; //Taxa de saque 
        }

        public override string ToString() {
            return "Conta: " + NumeroConta +
                " Titular: " + NomeTitular +
                " Saldo: " + SaldoConta;
        }


    }
}
