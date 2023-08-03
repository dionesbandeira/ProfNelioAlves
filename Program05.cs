/*

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves {
    internal class Program05 {
        private static void Main(string[] args) {
            Aluno aluno = new Aluno();

            Console.WriteLine("Informe o nome do aluno: ");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Informe as três notas do aluno: ");
            Console.WriteLine("Nota 1º trismetre que vale 30.0: ");
            aluno.n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota 2º trismetre que vale 35.0: ");
            aluno.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota 3º trismetre que vale 35.0: ");
            aluno.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Nota Final do Aluno: " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.StatusAluno() == "Aprovado") {
                Console.WriteLine("APROVADO!");
            }
            else {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("Faltaram " + aluno.NotaRestante() + " Pontos");
            }

        }

    }

}




*/