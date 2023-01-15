namespace _06_task6;
class Program
{
    static void Main(string[] args)
    {
        List<int> sayilar = new List<int>();
        Console.WriteLine("Lutfen 20 adet sayi giriniz");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Lutfen {0}.sayiyi giriniz:", i + 1);
            bool res = int.TryParse(Console.ReadLine(), out int outSayi);
            if (res)
            {
                sayilar.Add(outSayi);
            }
            else
            {
                Console.WriteLine("Hatali giris yaptiniz.");
                i--;
            }
        }
        sayilar.Sort();
        decimal ek3 = sayilar[0] + sayilar[1] + sayilar[2];
        decimal eb3 = sayilar[17] + sayilar[18] + sayilar[19];
        decimal ort1 = Math.Round(eb3 / 3);
        decimal ort2 = Math.Round(ek3 / 3);
        decimal result = ort1 + ort2;
        Console.WriteLine("En buyuk 3 sayinin ortalamasi: " + ort1);
        Console.WriteLine("En kucuk 3 sayinin ortalamasi: " + ort2);
        Console.WriteLine("En kucuk 3 sayinin ortalamasi: " + result);


    }
}
