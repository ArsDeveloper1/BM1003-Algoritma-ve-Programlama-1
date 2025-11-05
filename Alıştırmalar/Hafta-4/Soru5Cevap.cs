namespace Bos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz");
            int say = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < say; i++)
            {
                Console.WriteLine("Sayı:" + i * i);
            }
        }
    }
}
