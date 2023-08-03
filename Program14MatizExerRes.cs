/*Fazer um programa para ler um número inteiro N e uma matriz de
ordem N contendo números inteiros. Em seguida, mostrar a diagonal
principal e a quantidade de valores negativos da matriz.

Input: Output:               
3
5 -3 10   
15 8 2
7 9 -4
Main diagonal:
5 8 -4
Negative numbers = 2
*/


/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves {
    internal class Program14MatizExerRes {
        private static void Main(string[] args) {

            Console.Write("Informe um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());

            //Criar a Matrix
            int[,] mat = new int[n, n];

            //1º For percorre as linha 
            for (int i = 0; i < n; i++) {
                Console.Write("Informe três valores inteiros para linha "+i+": ");
                string[] values = Console.ReadLine().Split(' ');

                //2º For percorre as colunas
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Diagonal principal: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i]+ " ");
            }

            //Pecorrendo a matriz e contando quantos numeros negativos
            int count = 0;
            for (int i=0; i<n; i++) {
                for (int j=0; j<n; j++) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }

            Console.Write("\nQuantos elementos negativos: "+count);

        }
    }
}



*/