/*

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves {
    internal class Program08 {
        private static void Main(string[] args) {


            Console.Write("Informe um numero intgeiro: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
            
            Produto[] produto = new Produto[n];

            for (int i = 0; i < n; i++) {
                Console.Write("informe o nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write("Informe o preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Sintaxe de instanciação automatica
                //produto[i] = new Produto { Nome = nome, Preco = preco };
                //Acessando pelo construtor
                produto[i] = new Produto(nome, preco);
            }

            double soma = 0.0;
            for (int i=0; i<n; i++) {
                soma += produto[i].Preco;
            }

            double media = soma / n;
            Console.Write("A media de preço dos produtos é de: "+media.ToString("F2",CultureInfo.InvariantCulture));
                    
        }

    }
}


*/