namespace Bos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz");
            int say = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Çarpım:" + i * say);
            }
        }
    }
}
