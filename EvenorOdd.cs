﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class EvenorOdd
    {
        public static void findEvenorOdd()
        {
            int userInput;
            Console.Write("Enter a Number : ");
            userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
