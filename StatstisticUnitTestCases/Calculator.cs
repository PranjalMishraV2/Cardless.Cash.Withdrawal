using System.Reflection.Metadata;

namespace StatstisticUnitTestCases
{
    public class Calculator
    {
        public int Addition(int first, int second)
        { 
            return first + second;
        
        }

        public int Substraction(int first, int second)
        {
            if (first < second)
            {
                throw new ArgumentException($"First number {first} is less than second {second}");
            }

            return first - second;
        }

        public double Divide(int numerator, int denominator)
        {         
            return numerator / denominator;
        }

        public string DisplayName(string name)
        {
            return ($" You have enetered Name as : {name}");
        }
    }
}