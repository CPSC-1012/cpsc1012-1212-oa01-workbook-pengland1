/*
 * Created by Pierce England
 * 
 * Last Modified:2022-01-13
 */
using System;

namespace ProgrammingExercises
{
    internal class Program
    {

        static void Main(string[] args)
        {
            displayInfo();
            cylinderVolume();
            hexagonArea();
            integerSum();
            investmentCalc();
        }

        /*
         * Purpose: To allow a user to display their name, age, and annual salary
         * 
         * Inputs: name, age, annualPay
         * 
         * Outputs: N/A
         * 
         * Algorithm:
         *      Step 1) Store user inputs
         *      Step 2) Display user inputs.
         * 
         * Last Modified:2022-01-13
         */
        static void displayInfo()
        {
            int age;
            string name;
            double salary;

            //Step 1) Store user inputs
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter your salary: ");
            salary = double.Parse(Console.ReadLine());

            //Step 2) Display user inputs.
            Console.WriteLine($"My name is {name}, I am {age} years old, and my annual pay is {salary:C}.");
        }

        /*
         * Purpose: To allow a user to calculate the volume of a cylinder
         * 
         * Inputs: radius, length
         * 
         * Outputs: area, volume
         * 
         * Algorithm:
         *      Step 1) Store user inputs
         *      Step 2) Calculate area using formula
         *                  1) area = (radius * radius) * pi
         *                  2) volume = area * length
         *      Step 3)  Output the area and volume
         * 
         * Last Modified:2022-01-13
         */
        static void cylinderVolume()
        {
            double volume, area, radius, length;

            //Step 1) Store user inputs
            Console.Write("Enter cylinder radius: ");
            radius = double.Parse(Console.ReadLine());

            Console.Write("Enter cylinder length: ");
            length = double.Parse(Console.ReadLine());

            //Step 2) Calculate area using formula
            area = ((radius * radius) * Math.PI);
            volume = area * length;

            //Step 3)  Output the area and volume
            Console.WriteLine($"{"Cylinder area: "} {Math.Round(area, 4)}");
            Console.WriteLine($"{"Cylinder volume: "} {Math.Round(volume, 4)}");

        }

        /*
         * Purpose: To allow a user to calculate the area of a cylinder
         * 
         * Inputs: sideLength
         * 
         * Outputs: hexArea
         * 
         * Algorithm:
         *      Step 1) Store user inputs
         *      Step 2) Calculate area using formula
         *                  1) ((3 * sqrt(3)) / 2) * (length * length)
         *      Step 3)  Output the area and volume
         * 
         * Last Modified:2022-01-13
         */
        static void hexagonArea()
        {
            double sideLength,area;

            //Step 1) Store user inputs
            Console.Write("Enter the length of the side: ");
            sideLength = double.Parse(Console.ReadLine());

            //Step 2) Calculate area using formula
            area = ((3 * Math.Sqrt(3)) / 2) * (sideLength * sideLength);

            //Step 3)  Output the area and volume
            Console.WriteLine($"The area of the hexagon is: {Math.Round(area,4)}");
        }

        /*
         * Purpose: To allow a user to calculate the sum of all the digits in a number
         * 
         * Inputs: num
         * 
         * Outputs: sum
         * 
         * Algorithm:
         *      Step 1) Store user inputs
         *      Step 2) Calculate area using formula
         *                  Step 1) sum += num % 10;
                                    num = num / 10;
                            Step 2) repeat step 1 four times (this is okay due to the value constraints)
         *      Step 3)  Output sum of the num digits
         * 
         * Last Modified:2022-01-13
         */
        static void integerSum() {
            int num, sum = 0;

            Console.Write("Enter a number 0 - 1000: ");
            num = int.Parse(Console.ReadLine());

            sum += num % 10;
            num = num / 10;

            sum += num % 10;
            num = num / 10;

            sum += num % 10;
            num = num / 10;

            sum += num % 10;
            num = num / 10;

            Console.WriteLine($"The sum of the digits is: {sum}");
        }

        /*
         * Purpose: To allow the user to calculate an investment based on how many years will pass
         * 
         * Inputs: invAmount, interestRate, years
         * 
         * Outputs: futureVal
         * 
         * Algorithm:
         *      Step 1) Store user inputs
         *      Step 2) Calculate future value using formula
         *                  Step 1) futureVal = invAmount * Math.Pow(1.0 + ((interestRate / 100) / 12.0), 12.0 * years);
         *      Step 3)  Output future value
         * 
         * Last Modified:2022-01-13
         */
        static void investmentCalc() {
            double invAmount, interestRate, years, futureVal;

            //Step 1) Store user inputs
            Console.Write("Enter the investment amount: ");
            invAmount = Double.Parse(Console.ReadLine());

            Console.Write("Enter the annual interest rate: ");
            interestRate = Double.Parse(Console.ReadLine());

            Console.Write("Enter the number of years: ");
            years = Double.Parse(Console.ReadLine());

            //Step 2) Calculate future value using formula
            futureVal = invAmount * Math.Pow(1.0 + ((interestRate / 100) / 12.0), 12.0 * years);

            //Step 3)  Output future value
            Console.WriteLine($"Future value is {futureVal:C}");
        }
    }
}
