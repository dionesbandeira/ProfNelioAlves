/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves
{
    internal class Program30TrabalhandoArquivos
    {
        public static void Main(string[] args) 
        {

            //Objeto File nao é preciso instanciar,
            //Objeto FileInfo é necessario a sua instanciação 
            string sourcePath = @"C:\Users\dione\source\repos\Arq_01.txt";
            string targetPath = @"C:\Users\dione\source\repos\Arq_02.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines  ) 
                {
                    Console.WriteLine(line);
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }


        }

    }
}


*/
