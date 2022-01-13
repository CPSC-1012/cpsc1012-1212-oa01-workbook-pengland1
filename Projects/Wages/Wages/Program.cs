/*
 * Purpose: To calculate the total amount payed to employees in a pay period.
 * 
 * Inputs: regularHours, 
           overtimeHours
 * 
 * Constants: basePay,
              overtimePay
 * 
 * Derived Variables: regularWages,
                      overtimeWages
 * 
 * Outputs: totalWages
 * 
 * Algorithm: Step 1) Get inputs from user
 * 
 *            Step 2) Calculate totalWages using calculation:
 *                      regularWages = regularHours * regularPay;
 *                      overtimeWages = overtimeHours * overtimePay;
 *                      totalWages = regularWages + overtimeWages;
 *                      
 *            Step 3) Print out totalWages
 *            
 *            
 * Last Modified: 2022-01-12
 */

using System;

namespace Wages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const Double basePay = 25.0, overtimePay = 37.5;
            double regularHours, overtimeHours, regularWages, overtimeWages, totalWages;

            //Step 1) Get inputs from user
            Console.Write("Please input the total regular hours: ");
            regularHours = Double.Parse(Console.ReadLine());
            Console.Write("Please input the total overtime hours: ");
            overtimeHours = Double.Parse(Console.ReadLine());

            //Step 2) Calculate totalWages using calculation:
            regularWages = regularHours * basePay;
            overtimeWages = overtimeHours * overtimePay;
            totalWages = regularWages + overtimeWages;

            //Step 3) Print out totalWages
            Console.WriteLine($"The total amount paid to employees this pay period: {totalWages:C},", -10);
        }
    }
}
