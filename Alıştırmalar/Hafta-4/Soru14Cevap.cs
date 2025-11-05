namespace Bos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            double toplam = 0, ortalama = 0;
            Console.WriteLine("10 adet sınav notu giriniz:");
            for(int i = 0;i<dizi.Length;i++)
            {
                dizi[i] = Convert.ToInt32(Console.ReadLine());
                toplam += dizi[i];
                if(i+1== dizi.Length)
                {
                    ortalama = toplam / i;
                    Console.WriteLine("Sınıf ortalaması = " +ortalama);
                    Console.WriteLine("Ortalamadan yüksek notlar:");
                    
                }
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > ortalama)
                {
                    Console.WriteLine(dizi[i]);
                }
            }
        }
    }
}
