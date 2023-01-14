namespace _01_task1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lutfen pozitif bir sayi giriniz");
        string sayi = Console.ReadLine();
        bool result = int.TryParse(sayi, out int outSayi);
        List<int> dizi = new();

        if (result && outSayi > 0)
        {

            for (int i = 0; i < outSayi; i++)
            {
                Console.WriteLine("Lutfen {0}.sayiyi giriniz", i + 1);
                string number = Console.ReadLine();
                bool res2 = int.TryParse(number, out int outNumber);
                if (res2 && outNumber > 0)
                {
                    dizi.Add(outNumber);
                }
                else
                {
                    Console.WriteLine("Gecerli bir sayi girmediniz");
                    break;
                }
            }
            Console.WriteLine("Girmis oldugunuz sayilardan cift olanlar:");
            foreach (var item in dizi)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }

        }
        else
        {
            Console.WriteLine("Gecerli bir sayi girmediniz");
        }



    }
}


