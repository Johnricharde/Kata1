namespace Kata1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($"Is number square?: {IsSquare(input)}");
        }
        public static bool IsSquare(int n)
        {
            double sqrt = Math.Sqrt(n);

            return (sqrt % 1 == 0) ? true : false;
        }
    }
}
