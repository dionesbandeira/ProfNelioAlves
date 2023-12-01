/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves
{
    internal class Program33StreamWriter
    {
        public static void Main(string[] args)
        {
            //            
            string sourcePath = @"C:\Users\dione\source\repos\Arq_01.txt";
            string targetPath = @"C:\Users\dione\source\repos\Arq_02.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath)) 
                {
                    foreach (string line in lines) 
                    {
                        sw.WriteLine(line.ToUpper());
                    }

                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }

        }
    }
}



*/