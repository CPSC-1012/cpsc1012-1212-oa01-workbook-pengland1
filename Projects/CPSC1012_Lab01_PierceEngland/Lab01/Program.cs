/*
* Purpose: To output a 'receipt' for any given retail price and quantity.
*
* Input: retailPrice, qty
*
* Output: subTotal, total, fedTax, provTax, taxSum
*
* Written by: Pierce B. England
*
* Written for: Sam Wu
*
* Section: A01
*/
using System;

namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable intializations
            const double FedTaxRate = 0.05;
            const double ProvTaxRate = 0.06;
            double retailPrice;
            double qty;
            double subTotal;
            double total;
            double fedTax;
            double provTax;
            double taxSum;

            //output my fancy store name
            Console.WriteLine("Welcome to the \'We Have Everything\' Store");
            Console.WriteLine("=========================================");

            //gather inputs from user
            Console.Write("Please enter the price of your item: ");
            retailPrice = Double.Parse(Console.ReadLine());

            Console.Write("Now enter the quantity of the item(s): ");
            qty = Double.Parse(Console.ReadLine());

            //This is all of my calculations. Initially I had them in-line with the WriteLine
            //statements, it made more sense to put them all together for readability's sake
            subTotal = retailPrice * qty;
            provTax = subTotal * ProvTaxRate;
            fedTax = subTotal * FedTaxRate;
            taxSum = fedTax + provTax;
            total = subTotal + taxSum;

            //Print the invoice summary info with the above variables
            Console.WriteLine("Invoice Summary");
            Console.WriteLine("====================================");
            Console.WriteLine($"{"Sub Total: ",-20}{subTotal,15:C}\n");

            Console.WriteLine($"{"Provincial Tax: ",-20}{provTax,15:C}");
            Console.WriteLine($"{"Federal Tax: ",-20}{fedTax,15:C}");
            Console.WriteLine($"{"Total Tax: ",-20}{taxSum,15:C}\n");

            Console.WriteLine($"{"Total Price: ",-20}{total,15:C}");
            Console.WriteLine("====================================");
            Console.WriteLine("Thank you for your purchase, please come again soon.");
        }
    }
}
