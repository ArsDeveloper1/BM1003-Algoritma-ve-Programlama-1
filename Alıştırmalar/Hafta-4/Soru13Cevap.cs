namespace Bos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, tekrar, maks, ciftolmaanı;
            tekrar = 0;
            maks = 0;
            ciftolmaanı = 0;
            Console.WriteLine("Bir sayı değeri giriniz");
            k = Convert.ToInt32(Console.ReadLine());
            while (k != 1)
            {
                if (k % 2 == 0)
                {
                    k = k / 2;
                    tekrar++;
                }
                else
                {
                    k = (k * 3) + 1;
                    tekrar++;
                }


                if (maks < k)
                    maks = k;

                int degisken = k;
                while (degisken % 2 == 0 && degisken != 1)
                {
                    degisken /= 2;
                }

                if (degisken == 1)
                {
                    ciftolmaanı = k;
                    break;
                }

            }
            Console.WriteLine("K sayısının maksimum değeri:" + maks + " " + "İşlem kaç adım sürdü:"
                + tekrar + " " + "K sayısı hangi sayıdan sonra çift oldu:" + ciftolmaanı);
        }
    }
}
