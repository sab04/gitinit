using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumResult = 0;
            int num = 0;
            bool correctInt = false;

            if(args.Length == 0)
            {
                Console.WriteLine("Incorrect Arguments. Please enter arguments in this format: Sum 2 3");
                sumResult = 0;
            }
            else if(args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    correctInt = int.TryParse(args[i], out num);
                    if(correctInt)
                    {
                        sumResult = sumResult + int.Parse(args[i]);
                    }
                }
                Console.WriteLine("Sum = " + sumResult);
            }
            
            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();
        }
    }
}
