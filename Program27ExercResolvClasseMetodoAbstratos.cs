/* Fazer um programa para ler os dados de N figuras (N fornecido
pelo usuário), e depois mostrar as áreas destas figuras na
mesma ordem em que foram digitadas. */


/*

using ProfNelioAlves.Entities;
using ProfNelioAlves.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves
{
    internal class Program27ExercResolvClasseMetodoAbstratos
    {
        public static void Main(string[] args) 
        {

            List<Shape> shapes = new List<Shape>();

            Console.Write("Insira a quantidade de formas: ");
            int n= int.Parse(Console.ReadLine());


            for (int i=1; i<=n; i++) 
            {
                Console.WriteLine($"Shape {i} data:");

                Console.WriteLine("Rectangle or Circle (r/c)?");
                char tpForma = char.Parse(Console.ReadLine());

                Console.WriteLine("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (tpForma == 'r')
                {
                    Console.Write("Largura (Width): ");
                    double larg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Altura (Height): ");
                    double alt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(larg, alt, color));
                }
                else 
                {
                    Console.Write("Raio (Radius): ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(raio, color));

                }


            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");

            foreach(Shape shp in shapes)
            {
                Console.WriteLine(""+ shp.Area().ToString("F2",CultureInfo.InvariantCulture));
            }


        }

    }
}



*/