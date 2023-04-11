namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter your number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(" Number Sum => " + NumberSum(number));
        }
        public static int NumberSum(int number)
        {
            int NumberSum = 0;
            while (true)
            {
                if (number > 0)
                {
                    NumberSum += number % 10;
                    number = number / 10;
                }
                else
                {
                    return NumberSum;
                }

            }
        }
    }
}