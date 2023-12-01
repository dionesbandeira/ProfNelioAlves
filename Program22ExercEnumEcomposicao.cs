

/*
using System.Globalization;
using ProfNelioAlves.Entities;
using ProfNelioAlves.Entities.Enums;

namespace ProfNelioAlves
{
    internal class Program22ExercEnumEcomposicao
    {
        public static void Main(string[] args) 
        {

            Console.WriteLine("Enter Client data: ");

            Console.Write("Name: ");
            string ClientName = Console.ReadLine();
            Console.Write("E-mail: ");
            string ClientEmail = Console.ReadLine();
            Console.Write("Birth date (dd/mm/yyyy): ");
            DateTime ClientBirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Order data: ");
            Console.WriteLine("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(ClientName, ClientEmail, ClientBirthDate);
            Order order= new Order(DateTime.Now, status, client);

            Console.WriteLine("Quantos itens cabem neste pedido? ");
            int N = int.Parse(Console.ReadLine());

            for (int i=1; i<=N; i++) 
            {
                Console.WriteLine($"Digite dados do item: {i} ");

                Console.WriteLine("Product name: ");
                string productName = Console.ReadLine();

                Console.WriteLine("Product price");
                Double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);

                Console.WriteLine("Quantity: ");
                int productQuant = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(productQuant, productPrice, product);

                order.addItem(orderItem);

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }

    }
    
}






*/