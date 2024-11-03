namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
          return  num1 + num2;
        }

        public static double Add(double num1, double num2)
        {
            return  num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        static string Add(int num1, int num2, bool includeCurrency)
        {
            if (includeCurrency)
            {
                int sum = num1 + num2;
                return $"{sum} {(sum == 1 ? "dollar" : "dollars")}";
            }
            else
            {
                return "0"; // You can decide what to return when includeCurrency is false
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Add(num1: 4.0m, num2: 4.0m));
           //Console.WriteLine(Add(num1: 4, num2: 4));
           Console.WriteLine(Add(num1: 4.5, num2: 4.6));
           
           Console.WriteLine(Add(3, 5, true));  
           Console.WriteLine(Add(1, 1, true));  
           Console.WriteLine(Add(1, 0, true));  
           Console.WriteLine(Add(0, 0, false)); 
        }
    }
}
