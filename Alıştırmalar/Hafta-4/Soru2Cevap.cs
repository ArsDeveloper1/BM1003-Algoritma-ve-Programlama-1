namespace Bos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Bir sayı giriniz");
                int say = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + say;
            }
            Console.WriteLine("Girdiğiniz sayıların toplamı:" + toplam);
            Console.WriteLine("Girdiğiniz sayıların ortalaması:" + toplam / 10);
        }
    }
}
