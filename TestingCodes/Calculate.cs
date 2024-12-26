using System;
using System.Collections.Generic;
using System.Text;

namespace TestingCodes
{
    public class Calculate
    {

        public double area(int length, int width)
        {

            return length * width;
        }


        public int FactorialNum(int num)
        {
          
            if (num < 0)
                Console.WriteLine("Number must be non-negative.");

            int fact = 1;
            for (int i = num; i > 0; i--)
            {
                fact = fact * i;
            }
            return fact;

        }


        public int SumOfDigit(int n)
        {
            int sum = 0;
            do
            {
                int d = n % 10;
                sum = sum + d;
                n = n / 10;
            } while (n > 0);

            return sum;
        }


        public int Reverse(int n)
        {
            int rev = 0;
            do
            {
                int d = n % 10;
                rev = rev * 10 + d;
                n = n / 10;
            } while (n > 0);

            return rev;
        }


    }
}
