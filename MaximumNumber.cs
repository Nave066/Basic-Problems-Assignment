using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class MaximumNumber
    {
        public static void findMaximumNumbers()
        {
            Console.WriteLine("....Finding Maximum number amoung the three User inputs....");
            Console.WriteLine("Enter the First Number");
            int firstValue=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int secondValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            int thirdValue = Convert.ToInt32(Console.ReadLine());
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                Console.WriteLine("The biggest Value is" +firstValue);
                
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                Console.WriteLine("The biggest Value is" + secondValue);
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                Console.WriteLine("The biggest Value is" + thirdValue);
            }
            else
            {
                Console.WriteLine("All the numbers are same");
            }
        }
    }
}
