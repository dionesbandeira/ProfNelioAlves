/*Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais
podem ser pessoa física ou pessoa jurídica, e depois mostrar o valor do imposto pago por cada um,
bem como o total de imposto arrecadado.
Os dados de pessoa física são: nome, renda anual e gastos com saúde. Os dados de pessoa jurídica
são nome, renda anual e número de funcionários. As regras para cálculo de imposto são as
seguintes:
Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. Pessoas com
renda de 20000.00 em diante pagam 25% de imposto. Se a pessoa teve gastos com saúde, 50%
destes gastos são abatidos no imposto.
Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto
fica: (50000 * 25%) - (2000 * 50%) = 11500.00
Pessoa jurídica: pessoas jurídicas pagam 16% de imposto. Porém, se a empresa possuir mais de 10
funcionários, ela paga 14% de imposto.
Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica:
400000 * 14% = 56000.00
 */

/*
using ProfNelioAlves.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves
{
    internal class Program28ExrcFixClassesMetodosAbstratos
    {
        public static void Main(string[] args) 
        {

            List<TaxPayer> Contribuintes = new List<TaxPayer>();
            
            Console.Write("Insira o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i=1; i<=n; i++) 
            {
                Console.WriteLine($"\nTax payer {i} data:");

                Console.WriteLine("Individual or company (i/c)?");
                char tpContribuinte = char.Parse(Console.ReadLine());

                Console.WriteLine("Informe o nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tpContribuinte == 'i')
                {
                    Console.WriteLine("Informe Despesas com saúde: ");
                    double despSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Contribuintes.Add(new Individual(despSaude, nome, rendaAnual));
                }
                else 
                {
                    Console.WriteLine("Informe o numero de funcionarios: ");
                    int nFunc = int.Parse(Console.ReadLine());
                    Contribuintes.Add(new Company(nFunc, nome, rendaAnual));
                    
                }
                 
            }


            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double sum = 0.0;
            foreach (TaxPayer tax in Contribuintes) 
            {
                double todasRendaAnual = tax.Imposto();
                Console.WriteLine(tax.Name+": $"+ todasRendaAnual.ToString("F2",CultureInfo.InvariantCulture));
                sum+= todasRendaAnual;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
    
}



*/