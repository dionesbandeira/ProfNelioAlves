/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves
{
    internal class Program31TrabalhandoArquivosII
    {

        public static void Main(string[] args) 
        {
            //Forma Geral não resumido de seu uso!

            string path = @"C:\Users\dione\source\repos\Arq_01.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //sr = File.OpenText(path);
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream) 
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
            //Por que terei que fechar strem's independente se deu certo no try ou se caiu na Exceção!
            finally 
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        
        }


    }
}




*/