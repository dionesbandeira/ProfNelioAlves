/*

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves {
    internal class Program09 {
        private static void Main(string[] args) {

            Estudante[] estudante = new Estudante[10];

            Console.Write("Pousada com apenas 10 Quartos... \nNº: 1 \nNº: 2 \nNº: 3 \nNº: 4 \nNº: 5 \nNº: 6 \nNº: 7 \nNº: 8 \nNº: 9 \nNº: 10 \n");
            Console.Write("Informe quantos quartos será alugado: ");
            int n = int.Parse(Console.ReadLine());


            for (int i=0; i<n; i++) {

                Console.Write($"Aluguel #{i}: ");

                Console.Write("Informe o nome do responsavel: ");
                string nome = Console.ReadLine();

                Console.Write("Informe o e-mail do responsanvel: ");
                string email = Console.ReadLine();

                Console.Write("Informe o número do quarto: ");
                int nQuarto = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                estudante[nQuarto] = new Estudante(nome, email);

            }

            Console.WriteLine("Quartos Ocupados!");
            for (int i=0; i<10; i++) {
                if (estudante[i] != null) {
                    Console.Write(i +": " + estudante[i]+ "\n");                
                }
            }

        }
    }
}




*/