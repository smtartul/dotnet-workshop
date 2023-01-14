namespace _03_task3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lutfen pozitif bir sayi giriniz:");
        List<string> dizi=new List<string>();
        string sayi = Console.ReadLine();
        bool res = int.TryParse(sayi, out int outSayi);
        if (res && outSayi > 0)
        {
            Console.WriteLine("Lutfen {0} adet kelime giriniz", outSayi);
            for (int i = 0; i < outSayi; i++)
            {
                Console.WriteLine("Lutfen {0}. kelime giriniz", i + 1);
                string kelime=Console.ReadLine();
                dizi.Add(kelime);
            }
            Console.WriteLine("Sonuc:");
            dizi.Reverse();
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Hatali Giris Yaptiniz");
        }
    }
}
