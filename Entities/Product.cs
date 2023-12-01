using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfNelioAlves.Entities;
using ProfNelioAlves.Entities.Enums;

namespace ProfNelioAlves.Entities
{
    public class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public int Quantidade { get; set; }
        


        public Product() 
        {
        
        }

        public Product(string name, double price, int quantidade) : this(name, price)
        {
            Quantidade = quantidade;
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double TotalProduto()
        {
            return this.Price * this.Quantidade;
        }


        public virtual string PriceTag()
        {
            return Name
                   + " $ "
                   + Price.ToString("F2", CultureInfo.InvariantCulture); 
        }





    }
}
