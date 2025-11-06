namespace Alıstırma4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            Random random = new Random();
            int maksdeger = 0, mindeger = 20;
            Console.Write("Dizi elemanları = [");
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = random.Next(0, 100);
                Console.Write(dizi[i] + ",");
                if (i + 1 == dizi.Length)
                    Console.WriteLine(dizi[i] + "]");
            }
            int maksdegisken = 0, mindegisken = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > maksdeger)
                {
                    maksdeger = dizi[i];
                    maksdegisken = i+1;
                }
                if (dizi[i] < mindeger)
                {
                    mindeger = dizi[i];
                    mindegisken = i+1;
                }
                if (i + 1 == dizi.Length)
                {
                    Console.WriteLine("Maksimum değer " + maksdegisken + ". sayıdır ve " + maksdeger + " sayısıdır");
                    Console.WriteLine("Minumum değer " + mindegisken + ". sayıdır ve " + mindeger + " sayısıdır");
                }
            }
        }
    }
}
