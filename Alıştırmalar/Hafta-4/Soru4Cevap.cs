namespace Bos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int adet = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 12 == 0)
                {
                    toplam = toplam + i;
                    adet++;
                }
            }
            Console.WriteLine(toplam / adet);
        }
    }
}
