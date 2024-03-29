﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class HarmonicNumber
    {
        public static void FindHarmonicNumber()
        {
            int i, userInput;
            double s = 0.0;

            Console.Write("\n\n");
            Console.Write("Calculate the harmonic series and their sum:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number of terms : ");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            for (i = 1; i <= userInput; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} \n", userInput, s);
        }
    }
}
