namespace Alıstırma4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[20];
            Random random = new Random();
            Console.Write("Dizi elemanları = [");
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = random.Next(-20, 21);
                Console.Write(dizi[i] + ",");
                if (i + 1 == dizi.Length)
                    Console.WriteLine(dizi[i] + "]");
            }
            Console.WriteLine("Bir sayı giriniz:");
            int sayı = Convert.ToInt32(Console.ReadLine());
            Console.Write("Girdiğiniz sayı dizinin ");
            int a = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < sayı)
                {
                    a++;
                }
            }
            Console.Write(a + "elemanından büyüktür");
        }
    }
}
