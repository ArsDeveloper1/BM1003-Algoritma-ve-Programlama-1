namespace Bos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz");
            int say = Convert.ToInt32(Console.ReadLine());
            int toplam = 1;

            for (int i = say; 1 < i; i--)
            {
                toplam = toplam * i;
            }
            Console.WriteLine(toplam);
        }
    }
}
