using System;

namespace SaleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price,
                albertaTax = 1.05,
                total;

            Console.Write("Please enter the product price: ");
            string tempprice = Console.ReadLine();

            //price input
            price = double.Parse(tempprice);

            //price calculation
            total = price * albertaTax;

            //print receipt
            Console.WriteLine($"The price of the item is: {price:C}");
            Console.WriteLine($"The tax of the item is {(price * albertaTax) - price:C}");
            Console.WriteLine($"The total of the item is {total:C}");
        }
    }
}
