/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves
{
    internal class Program32BlocoUsing
    {

        public static void Main(string[] args)
        {
            //            
            string path = @"C:\Users\dione\source\repos\Arq_01.txt";

            try
            {
                //using (FileStream fs = new FileStream(path, FileMode.Open)) { using (StreamReader sr = new StreamReader(fs)){Lógica} }
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
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
