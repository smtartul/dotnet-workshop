namespace _05_task5;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lutfen 20 adet sayi giriniz:");
        List<int> primeNumbers = new List<int>();
        List<int> nonPrimeNumbers = new List<int>();

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Lutfen {0}.sayiyi giriniz:", i + 1);
            bool res = int.TryParse(Console.ReadLine(), out int outsayi);
            if (res && outsayi >= 0)
            {
                bool flag = false;
                for (int y = 2; y < outsayi; y++)
                {
                    if (outsayi % y == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag && outsayi > 2)
                {
                    primeNumbers.Add(outsayi);

                }
                else
                {
                    nonPrimeNumbers.Add(outsayi);

                }

            }
            else
            {
                Console.WriteLine("Hatali giris yaptiniz! Lutfen tekrar giris yapiniz:");
                i--;
            }
        }
        Console.WriteLine("Girmis oldugunuz sayilardan {0} tanesi asal sayidir.", primeNumbers.Count);
        Console.WriteLine("Girmis oldugunuz sayilardan {0} tanesi asal sayi degildir.", nonPrimeNumbers.Count);
        primeNumbers.Sort();
        nonPrimeNumbers.Sort();
        primeNumbers.Reverse();
        nonPrimeNumbers.Reverse();

        int primeTotal = 0;
        int nonPrimeTotal = 0;
        Console.WriteLine("Asal sayilar buyukten kucuge siralanmis sekilde:");
        for (int i = 0; i < primeNumbers.Count; i++)
        {
            primeTotal += primeNumbers[i];
            Console.WriteLine(primeNumbers[i]);
        }
        Console.WriteLine("Asal olmayan sayilar buyukten kucuge siralanmis sekilde:");
        for (int i = 0; i < nonPrimeNumbers.Count; i++)
        {
            nonPrimeTotal += nonPrimeNumbers[i];
            Console.WriteLine(nonPrimeNumbers[i]);
        }

        Console.WriteLine("Asal sayi adeti= " + primeNumbers.Count + " bu sayilarin ortalamasi= " + primeTotal / primeNumbers.Count);
        Console.WriteLine("Asal olmayan sayi adeti= " + nonPrimeNumbers.Count + " bu sayilarin ortalamasi= " + nonPrimeTotal / nonPrimeNumbers.Count);

    }
}
