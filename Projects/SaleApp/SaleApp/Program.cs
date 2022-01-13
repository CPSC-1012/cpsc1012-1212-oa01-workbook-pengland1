/*  
 *  Purpose:    Compute the total of a sales item using the price and tax.
 *  
 *  Inputs:     Price in dollars and cents.
 *  
 *  Outputs:    sales tax
 *              sales total
 *  
 *  Algorithm:  Step 1) Prompt and read in the sale price
 *              Step 2) Calculate the sale total using the formula
 *                          salesTax = salePrice * 0.05;
 *                          saleTotal = salePrice + salesTax;
 *              Step 3) Display the computed sale total
 *  Last Modified:  2022-01-12
*/
using System;

namespace SaleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salePrice, saleTax, saleTotal;
            const double saleTaxRate = 0.05;

            //Step 1) Prompt and read in the sale price
            Console.Write("Please enter your price: ");
            salePrice = Double.Parse(Console.ReadLine());

            //Step 2) Calculate the sale total using the formula
            saleTax = salePrice * saleTaxRate;
            saleTotal = salePrice + saleTax;

            //Step 3) Display the computed sale total
            Console.WriteLine($"{"Subtotal:", -15} {salePrice, 15:C}");
            Console.WriteLine($"{"Tax:", -15} {saleTax, 15:C}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"{"Total:", -15} {saleTotal, 15:C}");
        }
    }
}
