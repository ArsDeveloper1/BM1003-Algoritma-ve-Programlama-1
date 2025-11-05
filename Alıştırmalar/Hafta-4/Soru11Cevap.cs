namespace Bos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı, tekrar, toplam;
            toplam = 0;
            tekrar = 0;
            while (true)
            {
                Console.WriteLine("Bir sayı değeri giriniz");
                sayı = Convert.ToInt32(Console.ReadLine());
                tekrar++;
                if (sayı == 0)
                {
                    toplam = toplam + sayı;
                    Console.WriteLine("Sayıların Adedi:" + tekrar + " " + "Sayıların toplamı:" + toplam + " " + "Sayıların ortalaması" + toplam / tekrar);
                    break;
                }
                else
                {
                    toplam = toplam + sayı;
                    Console.WriteLine("Sayıların Adedi:" + tekrar + " " + "Sayıların toplamı:" + toplam + " " + "Sayıların ortalaması" + toplam / tekrar);

                }
            }
        }
    }
}
