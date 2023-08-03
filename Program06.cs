/*

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves {
    internal class Program06 {
        private static void Main(string[] args) {

            ContaBancaria conta;  

            Console.WriteLine(" Informe o titular da conta: ");
            string NomeCB = Console.ReadLine();

            Console.WriteLine(" Informe o número da conta:");
            int NumeroCB = int.Parse(Console.ReadLine());

            Console.WriteLine("Haverá deposito inicial? (S/N): ");
            char PossuiDep = char.Parse(Console.ReadLine());

            if (PossuiDep == 's' || PossuiDep == 'S') {
                Console.WriteLine("informe o valor de deposito inicial: ");
                double ValorDepInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(NomeCB, NumeroCB, ValorDepInicial);
            }
            else {
                conta = new ContaBancaria(NomeCB, NumeroCB);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Informe um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Depositar(quantia);
            Console.WriteLine("Dados atualizados: \n"+conta);

            Console.WriteLine();
            Console.WriteLine("Informe um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(quantia);
            Console.WriteLine("Dados atualizados: \n" + conta);


        }
    }
}



*/