using NUnit.Framework;
using TestingCodes;

namespace TestProject
{
    public class Tests
    {

        private Calculate calc;
        [SetUp]
        public void Setup()
        {
            calc = new Calculate();
        }

        [Test]
        public void FactorialOfNumber()
        {
            //arrange
            int num = 4;

            //act
            int result = calc.FactorialNum(num);

            //assert
            Assert.AreEqual(24, result);
        }


        [Test]
        public void ShouldReturnAreaOfRectangle()
        {

            //arrange
            int length = 2;
            int breadth = 3;

            //act
            double result = calc.area(length, breadth);

            //assert
            Assert.AreEqual(6, result);

        }

        [Test]
        public void ShouldReturnIntSumIfDigit()
        {
            int num = 1234;

            int result= calc.SumOfDigit(num);

            Assert.AreEqual(10, result);
        }

        [Test]
        public void ShouldReturnReverseOfNumber()
        {
            int num = 35345;

            int result= calc.Reverse(num);

            Assert.AreEqual(54353,result);
        }
    }
}