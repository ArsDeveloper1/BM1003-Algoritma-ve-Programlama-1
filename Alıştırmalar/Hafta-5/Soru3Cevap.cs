namespace Alıstırma4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[20];
            Random random = new Random();
            double toplamcift = 0, toplamtek = 0;
            Console.Write("Dizi elemanları = [");
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = random.Next(0, 21);
                Console.Write(dizi[i] + ",");
                if (i + 1 == dizi.Length)
                    Console.WriteLine(dizi[i] + "]");
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    toplamcift += dizi[i];
                }
                else
                {
                    toplamtek += dizi[i];
                }
            }
            double oran = toplamcift / toplamtek;
            Console.WriteLine(toplamtek);
            Console.WriteLine(toplamcift);
            Console.Write("Çift sayıların tek sayılara oranı: " + oran);
        }
    }
}
