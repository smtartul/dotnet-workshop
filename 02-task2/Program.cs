namespace _02_task2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lutfen iki adet pozitif sayi giriniz!");
        Console.WriteLine("Lutfen ilk sayiyi giriniz:");
        List<int> dizi = new List<int>();
        string n = Console.ReadLine();
        bool res = int.TryParse(n, out int outn);
        if (res && outn > 0)
        {
            Console.WriteLine("Lutfen ikinci sayiyi giriniz:");
            string m = Console.ReadLine();
            bool res2 = int.TryParse(m, out int outm);
            if (!res2 || outm <= 0)
            {
                Console.WriteLine("Hatali giris yaptiniz!");
            }
            else
            {
                Console.WriteLine("Lutfen {0} adet sayi girisi gerceklestirin", outn);
                for (int i = 0; i < outn; i++)
                {
                    Console.WriteLine("Lutfen {0}. sayiyi giriniz:", i + 1);
                    string sayi = Console.ReadLine();
                    bool res3 = int.TryParse(sayi, out int outsayi);
                    if (res3 && outsayi > 0)
                    {
                        if (outsayi % outm == 0)
                        {
                            dizi.Add(outsayi);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatali giris yaptiniz!");
                        break;
                    }

                }
                Console.WriteLine("Sonuc:");
                foreach (var item in dizi)
                {
                    Console.WriteLine(item);
                }
            }


        }
        else
        {
            Console.WriteLine("Hatali giris yaptiniz!");
        }



    }
}
