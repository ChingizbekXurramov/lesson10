namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Gotonumber:
            Console.Write("enter first number==> ");
            int number = int .Parse(Console.ReadLine());
            Console.Write("Enter second number==> ");
            int number2 = int .Parse(Console.ReadLine());
            
            if (number < number2)
            {
                for(int i = number; i < number2; i++) 
                {
                    if (number % 2 != 0)
                    {
                        Console.Write(i + ",");
                    }
                }
            }
            else
            {
                Console.WriteLine( "Please enter > number"); 
                goto Gotonumber;
                
            }
         
        }
    }
}