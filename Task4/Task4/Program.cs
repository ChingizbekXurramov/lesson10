namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number : ");
            string number = Console.ReadLine();
            string result = "";

            for (int i = number.Length; i > 0; i--)
            {
                if (i % 3 == 0 && i != number.Length)
                {
                    result += ",";
                }
                result += number[number.Length - i];
            }

            Console.WriteLine(result);

        }
    }
}