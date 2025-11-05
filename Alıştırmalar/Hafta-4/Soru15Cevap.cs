namespace Bos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int say1, say2;
            Console.WriteLine("Birinci sayıyı giriniz");
            say1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            say2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Birinci sayı:" + say2);
            Console.WriteLine("ikinci sayı:" + say1);
        }
    }
}
