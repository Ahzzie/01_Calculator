using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Calculator
{
    public class Calculator
    {
        internal static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        internal static int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        internal static int Sum(int[] numbers)
        {
            int number = 0;

            foreach (int numb in numbers)
            {
                number = number + numb;
            }
            return number;
        }

        internal static int Multiply(int[] numbers)
        {
            int number = 1;

            foreach (int numb in numbers)
            {
                number = number * numb;
            }
            return number;
        }

        internal static int Power(int[] numbers)
        {

            return (int) Math.Pow(numbers[0], numbers[1]);
           
        }

        internal static int Factorial(int v)
        {
            int x = 1;
                for(int i = v; i>0; i--)
            {
                x = x * i;
            }
            return x;
        }
    }
}
