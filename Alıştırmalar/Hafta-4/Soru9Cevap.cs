namespace Bos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı, pozitif, negatif;
            pozitif = negatif = 0;
            while (true)
            {
                Console.WriteLine("Bir sayı giriniz");
                sayı = Convert.ToInt32(Console.ReadLine());
                if (sayı == 0)
                {
                    Console.WriteLine("Pozitif sayı toplamı:" + pozitif);
                    Console.WriteLine("Negatif sayı toplamı:" + negatif);
                    break;
                }
                if (sayı > 0)
                {
                    pozitif = pozitif + sayı;
                }
                else if (sayı < 0)
                {
                    negatif = negatif + sayı;
                }
            }
        }
    }
}
