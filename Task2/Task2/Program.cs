namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number=> ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i < number; i++) 
            { 
                if(i % 3 == 0) 
                {
                    Console.Write(i);
                    Console.WriteLine("too");
                }
                else if (i % 5 == 0) 
                {   
                    Console.Write(i);
                    Console.WriteLine(" Bar");                
                }
                else if(i % 3 == 0 && i % 5 == 0) 
                {
                    Console.Write(i);
                    Console.WriteLine("too bar");
                }
            }
            
        }
    }
}