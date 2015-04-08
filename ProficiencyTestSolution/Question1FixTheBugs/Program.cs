using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question1FixTheBugs
{
    #region Question 1
    /*
     * Bug 1 : Logic wise, there should be braces around a and b 
     *      Fix for Bug 1 : added braces around a + b
     * 
     * Bug 2 : Result wise, it will always return integer and not double 
     *      Fix for Bug 2 : converted ( a + b ) as double
     */
    public class MathUtils
    {
        public static double Average(int a, int b)
        {
            return (double)(a + b) / 2;
        }
    }

    public class Program
    {
        public static void Main(String[] ar)
        {
            while (true)
            {
                Console.Write("Enter the value for a (only integer numbers) : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the value for b (only integer numbers) : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nThe Average : " + MathUtils.Average(a, b) + "\n");
            }
        }
    }
    #endregion
}
