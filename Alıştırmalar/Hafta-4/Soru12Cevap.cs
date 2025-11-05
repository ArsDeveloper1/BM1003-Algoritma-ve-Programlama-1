namespace Bos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı, değer, mod;
            değer = 0;
            mod = 0;
            Console.WriteLine("Bir sayı değeri giriniz");
            sayı = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                mod = sayı % 10;
                sayı = sayı / 10;
                if (mod > değer)
                {
                    değer = mod;
                }
                if (sayı <= 0)
                {
                    break;
                }

            }
            Console.WriteLine("En büyük sayı:" + değer);
        }
    }
}
