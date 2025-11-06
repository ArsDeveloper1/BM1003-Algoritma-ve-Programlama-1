namespace Alıstırma4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            Console.WriteLine("Bir sayı giriniz");
            
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Dizi elemanları = [");
            for (int i = 0; i<dizi.Length; i++)
            {
                Console.Write(dizi[i]+",");
                if(i+1==dizi.Length)
                {
                    Console.Write(dizi[i]);
                }
            }
            Console.WriteLine("]");
        }
    }
}
