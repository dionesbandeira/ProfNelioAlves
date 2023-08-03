/*

using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves {
    internal class ProgramList {
        private static void Main(string[] args) {

            //Declarando uma variavel do tipo list e instanciando. Populando a lista
            //List<string> list = new List<string>() {"Diones","Simone","Sarah" };
            List<string> list = new List<string>();
            //Se fosse um produto
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
                        
            list.Insert(2,"Marco");
            
            foreach (string obj in list) {
                Console.WriteLine("Lista: "+obj);
            }

            Console.Write("List Count: " + list.Count);

            //string s1 = list.Find(Test);
            string s1 = list.Find(x => x[0] =='A');
            Console.Write("\nPrimeiro nome que aparece com A: "+s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.Write("\nÚltimo nome que aparece com A: "+s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.Write("\nPosição da Lista com A: "+pos1);

            int posUlt = list.FindLastIndex(x=> x[0]=='A');
            Console.Write("\nÚltima posição da lista com A: "+posUlt);

            List<string> list2 = list.FindAll(x=> x.Length == 5);

            Console.Write("\nLista com nomes que contém 5 caracteres: \n");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.Write("Lista com remoção do Alex: ");
            foreach (string obj in list){
                Console.Write("\n"+obj);            
            }

            Console.Write("\nLista com filtro de remoção das palavras inciais com M: ");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list) {
                Console.Write("\n"+obj);
            }

            Console.Write("\nLista com remoção da posição 1 da lista: ");
            list.RemoveAt(1);
            foreach (string obj in list) {
                Console.Write("\n" + obj);
            }

            Console.Write("\nLista com remoção a partir da posição, 1 elemento: ");
            list.RemoveRange(0,1);
            foreach (string obj in list) {
                Console.Write("\n" + obj);
            }


        }

        //Função de exeplo
        //static bool Test(string s) {
            //return s[0] == 'A';
        //}

    }
}


*/