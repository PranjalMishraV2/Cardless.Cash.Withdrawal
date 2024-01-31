using NUnit.Framework;
using StatstisticUnitTestCases;
using System.Reflection;

namespace NUnitDemo.Test
{

    [TestFixture]
    public class CalculatorTest
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }


        [Test]
        public void Test_Addition_With_Integer()
        {
            //var cal = new Calculator();
            var result = _calculator.Addition(3, 5);
            Assert.AreEqual(8, result);
        }

        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(3, 5, 8)]
        public void Test_Addition_Wiith_MultipleInputs(int first, int second, int expectedResult)
        {
            var cal = new Calculator();
            var calculatedResult = cal.Addition(first, second);
            Assert.AreEqual(expectedResult, calculatedResult);        
        }

        [Test]
        public void Test_Substraction_With_ArgumentException()
        {   var cal = new Calculator();
            Assert.Catch <SystemException>(() => cal.Substraction(4,5));
            //Assert.Catch <ArgumentException>(() => cal.Substraction(4,5));
            //Assert.Throws<ArgumentException>(() => cal.Substraction(4, 3));
            Assert.Throws<ArgumentException>(() => cal.Substraction(4, 5));
        }

        [Test]
        public void DivisionOfTwoNumbers()
        {
            //arrange
            int numerator = 300;
            int denominator = 100;

            //var cal = new Calculator();
            var result = (double)_calculator.Divide(numerator, denominator);
            Assert.AreEqual(3,result);
        }

        [TestCase(100,25,4)]
        [TestCase(1000, 25, 39)]
        [TestCase(450, 25, 18)]
        public void DivisionOfTwoNumbers_WithMultiple( int numerator, int denominator, double expectedResult)
        {
            //arrange
            //numerator = 300;
            //denominator = 100;

            var cal = new Calculator();
            var result = (double)cal.Divide(numerator, denominator);
            Assert.AreEqual(expectedResult, result);
        }

        //Providing a Source With the TestCaseSource Attribute

        [TestCaseSource(nameof(SourceProvider))]
        public void DivisionOfTwoNumbers_WithInputSource(int numerator, int denominator, double expectedResult)
        {  
            var cal = new Calculator();
            var result = (double)cal.Divide(numerator, denominator);
            Assert.AreEqual(expectedResult, result);
        }
        public static IEnumerable<int[]> SourceProvider()
        {
            yield return new int[] { 300, 100, 3 };
            yield return new int[] { 400, 200, 2 };
        }

        [Ignore("Ignored Test")]
        public void Test_ToIgnore()
        {
        }


        //To Run Specific Test cases or Run Test cases for particular Category 


        [Test, Property("Priority", 1), Category("CategoryA")]
        public void TestMethod1()
        {
            var cal = new Calculator();
            var result = cal.DisplayName("Pranjal");
            Assert.IsTrue(result != null);
            Console.Write(result);
        }        

        [Test, Property("Priority", 2)]
        public void TestMethod2()
        {
        }
    }
}