﻿using System;
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
            int num = 0;
            bool correctInt = false;
            List<string> list = new List<string>();
            char[] separator = { '\n' }; //Initialized
            string s = "";
            string regEx = @"^\\\\.?\\\\$";

            if(args.Length == 0)
            {
                Console.WriteLine("Incorrect Arguments. Please enter arguments in this format: Sum 2 3");
                sumResult = 0;
            }
            else if(args.Length > 0)
            {
                for (int i = 1; i < args.Length; i++)
                {
                    //Find the delimiter
                    if(Regex.Match(args[i], regEx).Success)
                    {
                        s = args[i].Substring((args[i].IndexOf("\\\\") + 2), 1).ToString();
                        separator = s.ToArray();
                        break;
                    }                  
                }
                for (int i = 2; i < args.Length; i++)
                {                    
                    if (args[i].Contains(s))
                    {
                        list = args[i].Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                        foreach (var l in list)
                        {
                            correctInt = int.TryParse(l, out num);
                            if (correctInt)
                            {
                                sumResult = sumResult + int.Parse(l);
                            }
                        }
                    }
                    else
                    {
                        correctInt = int.TryParse(args[i], out num);
                        if (correctInt)
                        {
                            sumResult = sumResult + int.Parse(args[i]);
                        }
                    }   
                }
                Console.WriteLine("Sum = " + sumResult);
            }
            
            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();
        }
    }
}
