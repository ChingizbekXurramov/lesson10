namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            Console.Write("Enter ROW number=>  ");
            int row = int.Parse(Console.ReadLine());

            int[][] arry1 = new int[row][];
            for (int i = 0; i < row; i++)
            {
                arry1[i] = new int[row];
                for (int j = 0; j < row; j++)
                {
                    arry1[i][j] = random.Next(1, 10);
                    Console.Write($" {arry1[i][j]}");
                }
                Console.WriteLine();
            }

            Console.Write("Result Sum=> ");
            Multiplication(arry1);
            Console.WriteLine();


            Main(args);
        }
        public static void Multiplication(int[][] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (i == j)
                    {
                        sum += array[i][j];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}