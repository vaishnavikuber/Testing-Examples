using System;

namespace TestingCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();

            //factorial
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial is " + calculate.FactorialNum(num));

            //area of rectangle 
            Console.WriteLine("Enter length");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter width");
            int width = int.Parse(Console.ReadLine());

            double res = calculate.area(length, width);
            Console.WriteLine(res);

            //sum of number
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            calculate.SumOfDigit(n);


            //reverse
            Console.WriteLine("Enter a number to reverse");
            int number = Convert.ToInt32(Console.ReadLine());
            int rev = calculate.Reverse(number);
            Console.WriteLine(rev);
        }
    }
}
