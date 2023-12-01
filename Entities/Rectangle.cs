using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfNelioAlves.Entities.Enums;

namespace ProfNelioAlves.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }


        public Rectangle(double width, double height, Color color) : base (color)
        {
            Width = width;
            Height = height;
        }

        //Método sobre escrito pelo metodo abstrato 
        public override double Area()
        {
            return Width * Height;
        }
    }
}
