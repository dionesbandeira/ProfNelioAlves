/*

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves {
    internal class Program07 {
        private static void Main(string[] args) {

            Console.Write("Informe um numero Inteiro: ");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            double sum = 0.0;
            double media = 0.0;

            for (int i=0; i<n; i++) {
                Console.Write("Informe a altura da posição "+i+" -> ");
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                sum += vect[i];
            }

            media = sum / 2;
            Console.Write("A média das alturas é: "+ media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}



*/