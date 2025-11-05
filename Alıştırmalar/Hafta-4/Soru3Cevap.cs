namespace Bos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 7 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
