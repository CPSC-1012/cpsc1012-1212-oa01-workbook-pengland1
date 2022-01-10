using System;

namespace SaleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price,
                tax,
                total;

            price = 29.99;
            tax = price * 0.05;
            total = price + tax;

            Console.WriteLine($"The price of the item is: {price:C}");
            Console.WriteLine($"The tax of the item is {tax:C}");
            Console.WriteLine($"The total of the item is {total:C}");
        }
    }
}
