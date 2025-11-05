namespace Bos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı1, sayı2;
            sayı1 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Bir sayı değeri giriniz");
                sayı2 = Convert.ToInt32(Console.ReadLine());
                if (sayı2 > sayı1)
                {
                    sayı1 = sayı2;
                }
            }
            Console.WriteLine(sayı1);
        }
    }
}
