using TestingCodes;

namespace MSTestProject
{
    [TestClass]
    public sealed class Test1
    {
        Calculate calc = null;

        [TestInitialize]
        public void SetUp()
        {
            calc = new Calculate();
        }

        [TestMethod]
        //Arrange
        [DataRow(4, 24)]
        [DataRow(6, 720)]
        [DataRow(3, 6)]
        public void Factorial(int num, int expected)
        {

            //Act
            int result = calc.FactorialNum(num);

            //Assert
            Assert.AreEqual(expected, result);

        }



        [TestMethod]
        //Arrange
        [DataRow(3.5, 3.9, 13.65)]
        [DataRow(5.8, 4.7, 27.26)]
        public void AreaOfRectangle(double lenght, double bredth, double expected)
        {
            double result = calc.area(lenght, bredth);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(65787, 33)]
        [DataRow(457698, 39)]
        public void SumOfGivenDigits(int num, int expected)
        {
            int result = calc.SumOfDigit(num);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(69878, 87896)]
        [DataRow(123456789, 987654321)]
        public void Reverse(int num, int expected)
        {
            int result = calc.Reverse(num);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]

        [DataRow("vaishnavi", "kuber", "vaishnavi kuber")]
        [DataRow("shri", "prabha", "shri prabha")]
        public void NameDisplay(string fName, string lNmae, string expected)
        {
            string result = calc.DisplayName(fName, lNmae);

            Assert.AreEqual(expected, result);
        }

       
        [TestMethod]
        
        [DataRow(new double[] { 4.5, 6.4, 9.8, 2.5 }, 5.800000000000001)]
        [DataRow(new double[] { 6.7,8.5,7.2,6.8,9.4,3.8 }, 7.066666666666666)]
        public void ReturnAverage(double[] array,double expected)
        {
            
            double result= calc.Average(array);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(6,true)]
        [DataRow(28,true)]
        [DataRow(4,false)]
        public void CheckPerfectNumber(int num, bool expected)
        {
            bool result= calc.PerfectNumber(num);

            Assert.AreEqual(expected, result);
        }
    }
}
