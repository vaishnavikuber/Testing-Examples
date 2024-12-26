using System;

namespace TestingCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();

            //factorial
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Factorial is " + calculate.FactorialNum(num));

            //area of rectangle 
            //Console.WriteLine("Enter length");
            //int length = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter width");
            //int width = int.Parse(Console.ReadLine());

            //double res = calculate.area(length, width);
            //Console.WriteLine(res);

            //sum of number
            //Console.WriteLine("Enter the number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //calculate.SumOfDigit(n);


            //reverse
            //Console.WriteLine("Enter a number to reverse");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int rev = calculate.Reverse(number);
            //Console.WriteLine(rev);

           //double r= calculate.Average(new double[] { 4.5, 6.4, 9.8, 2.5 });
           // Console.WriteLine(r);

           //Console.WriteLine( calculate.Average(new double[] { 6.7, 8.5, 7.2, 6.8, 9.4, 3.8 }));

            Console.WriteLine(calculate.PerfectNumber(6));
        }
    }
}
