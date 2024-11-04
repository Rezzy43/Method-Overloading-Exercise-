namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        public static string Add(int numOne, int numTwo, bool isCurrency)
        {
            var sum  = numOne + numTwo;

            if (isCurrency && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCurrency && sum == 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args)
        {
           // Called the Add method for integers
           int intResult = Add(1, 2); // I called the first overloaded method
           Console.WriteLine($"Add(int, int): {intResult}");
           
           // Called the Add method for decimals
           decimal decimalResult = Add(1.5m, 2.5m);
           Console.WriteLine($"Add(decimal, decimal): {decimalResult}");
           
           // Called the Add method with three parameters
           string currencyResult = Add(1, 2, isCurrency: true);
           Console.WriteLine($"Add(int, int, bool): {currencyResult}");
        }
    }
}
