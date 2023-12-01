/*Fazer um programa para ler os dados de N
produtos (N fornecido pelo usuário). Ao final,
mostrar a etiqueta de preço de cada produto na
mesma ordem em que foram digitados.
Todo produto possui nome e preço. Produtos
importados possuem uma taxa de alfândega, e
produtos usados possuem data de fabricação.
Estes dados específicos devem ser
acrescentados na etiqueta de preço conforme
exemplo (próxima página). Para produtos
importados, a taxa e alfândega deve ser
acrescentada ao preço final do produto.
Favor implementar o programa conforme
projeto ao lado.*/


/*
using ProfNelioAlves.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves
{
    internal class Program26ExerFixaSecao10
    {
        public static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            Console.Write("Quantidade de Produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.Write($"Product {i} Date: " );

                Console.WriteLine("Common, used or imported (c/u/i) ?");
                char tpProduct = char.Parse(Console.ReadLine());

                Console.WriteLine("Informe o nome do produto: ");
                string name = Console.ReadLine();

                Console.WriteLine("Informe o preço do produto: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tpProduct == 'c')
                {
                    products.Add(new Product(name, priceProduct));
                }
                else if (tpProduct == 'u')
                {
                    Console.Write("Dta de fabricação: (DD/MM/YYYY) ");
                    DateTime date = DateTime.Parse(Console.ReadLine()); 
                    products.Add(new UsedProduct(name, priceProduct, date));
                }
                else
                {
                    Console.Write("Informe a taxa personalizada: ");
                    double txPersonalizada = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, priceProduct, txPersonalizada));

                }

            }   
            
            Console.WriteLine();
            Console.WriteLine("ETIQUETAS DE PREÇO:");
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }


        }

    }    
}


*/

