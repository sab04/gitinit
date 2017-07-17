using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumResult = 0;
            int num1 = 0;
            int num2 = 0;
            bool correctInt1 = false;
            bool correctInt2 = false;

            if (args.Length == 0)
            {
                Console.WriteLine("Incorrect Arguments. Please enter arguments in this format: Sum 2 3");
                sumResult = 0;
            }
            else if (args.Length == 1)
            {
                sumResult = 0;
            }
            else if (args.Length == 2)
            {
                correctInt1 = int.TryParse(args[1], out num1);
                if (correctInt1)
                    sumResult = int.Parse(args[1]);
            }
            else if (args.Length == 3)
            {
                correctInt1 = int.TryParse(args[1], out num1);
                correctInt2 = int.TryParse(args[2], out num2);
                if (correctInt1 && correctInt2)
                    sumResult = int.Parse(args[1]) + int.Parse(args[2]);
                else if (correctInt1)
                    sumResult = int.Parse(args[1]);
                else
                    sumResult = int.Parse(args[2]);
            }
            Console.WriteLine("Sum = " + sumResult);
            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();
        }
    }
}
