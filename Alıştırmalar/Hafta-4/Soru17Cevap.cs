namespace Bos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İki basamaklı bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int onlar_basamagi;
            int birler_basamagi = sayi % 10;
            onlar_basamagi = ((sayi - birler_basamagi) / 10);

            int yeni_sayi = ((birler_basamagi*10)+onlar_basamagi);
            Console.WriteLine("Yeni sayı: "+ yeni_sayi);
            if(yeni_sayi>sayi)
            {
                Console.WriteLine("Yeni sayı daha büyük: "+yeni_sayi);
            }
            else if(yeni_sayi==sayi)
            {
                Console.WriteLine("Birşey değişmedi sayı aynı halde kaldı: "+yeni_sayi);
            }
            else
            {
                Console.WriteLine("İlk sayı daha büyük: "+sayi);
            }
        }
    }
}
