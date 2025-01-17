namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isCurrency)
        {
            var sum = num1 + num2;
            
            if(isCurrency && (sum > 1))
            {
                return $"{sum} dollars";
            }
            else if (isCurrency && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(num1: 1, num2: 1, isCurrency: false));
        }
    }
}
