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
    internal class OrderItem
    {
        public int Quant { get; set; }
        public double Price { get; set; } 
        public Product Product { get; set; }

        
        public OrderItem()
        {

        }
        public OrderItem(int quant, double price, Product product)
        {
            Quant = quant;
            Price = price;
            Product = product;
        }

        public double subTotal() 
        {
            return Price * Quant;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Product.Name);
            sb.Append(":");
            sb.AppendLine("$ ");
            sb.Append(Price.ToString("F2",CultureInfo.InvariantCulture));
            sb.Append(" Quantity :");
            sb.Append(Quant);
            sb.Append("Subtotota : $");
            sb.Append(subTotal().ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }



    }
}
