/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves
{
    internal class Program34Directory
    {

        public static void Main(string[] args)
        {
            //            
            string path = @"C:\Users\dione\source\repos\Zyfolder";
            
            try
            {
                //Listar todasa as pastas do directorio
                //*.* qualquer nome de arquivo . qualquer extensão
                IEnumerable<string> foldersc = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDER'S: ");
                foreach (string folder in foldersc) 
                {
                    Console.WriteLine(folder);
                }

                //Listando os arquivos 
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                //Criando uma nova pasta a partir do diretorio atual "Path"
                Directory.CreateDirectory(path + "\\novapasta");

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