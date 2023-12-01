using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfNelioAlves.Entities.Enums;



namespace ProfNelioAlves.Entities
{
    internal abstract class Shape
    {

        public Color color { get; set; }

        protected Shape()
        {

        }
        protected Shape(Color color)
        {
            color = color;
        }

 

        //Um método abstrato 
        public abstract double Area(); 



    }
}
