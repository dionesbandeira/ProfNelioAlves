/*Fazer um programa para ler dois números inteiros M e N, e depois ler
uma matriz de M linhas por N colunas contendo números inteiros,
podendo haver repetições. Em seguida, ler um número inteiro X que
pertence à matriz. Para cada ocorrência de X, mostrar os valores à
esquerda, acima, à direita e abaixo de X, quando houver, conforme
exemplo.

3 4
10 8 15 12
21 11 23 8
14 5 13 19
8

Position 0,1:
Left: 10
Right: 15
Down: 11
Position 1,3:
Left: 23
Up: 12
Down: 19

 */




/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves {
    internal class Program15MatrizExerFix {
        public static void Main(string[] args) {

            Console.Write("Informe um numero inteiro para N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Informe um numero inteiro para M: ");
            int m = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++) {
                Console.Write("Informe um numero inteiro para Linha: ");
                //mat[i, 0] = i;
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Informe um numero da Matriz: ");
            int buscaValue = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (mat[i, j] == buscaValue) {
                        Console.WriteLine("Position: " + i + "," + j);
                        if (i > 0) {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }
                        if (j > 0) {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                        if (i < n-1) {
                            Console.WriteLine("A baixo: " + mat[i + 1, j]);
                        }
                        if (j < m-1) {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }

                    }
                }
            }

        }
    }
}




*/