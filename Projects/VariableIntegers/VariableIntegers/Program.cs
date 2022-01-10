using System;

namespace VariableIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chequing;
            long days;

            chequing = 20;
            days = 189000;

            Console.WriteLine($"Our account balance is {chequing:C}");
            Console.WriteLine($"About {days} days ago Columbus stood on this spot.");
        }
    }
}
