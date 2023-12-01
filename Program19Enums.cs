/*

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfNelioAlves.Entities;
using ProfNelioAlves.Entities.Enums;
using static System.Net.Mime.MediaTypeNames;

namespace ProfNelioAlves
{
    internal class Program19Enums
    {
        public static void Main(string[] args)
        {

            //Instanciando a entidade'classe' e informando os valores  

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
                        
            Console.WriteLine("Valores da Entidade Order: "+order);

            //Realizadno a conversção para string
            String txt = OrderStatus.PendingPayment.ToString();

            //Realizadno a conversção de tring para Enums
            //--OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            //Mas senão funcionar na versao do c#, tente desse jeito
            //--OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus),"Delivered");

            //Se mesmo assim ainda tiver dando erro, há ainda uma terceira forma:
            OrderStatus os;
            Enum.TryParse("Delivered", out os);

            Console.WriteLine("Valores da Entidade Order convertidos para o tipo Etring: "+txt);
            Console.WriteLine("Valores da Entidade Order convertidos para tipo enumerados: " +os);


        }
    }
}




*/