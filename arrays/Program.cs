namespace arrays;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lutfen ortalamasini hesaplamak istediginiz sayi adetini giriniz:");
        int diziUzunlugu=int.Parse(Console.ReadLine());
        int[] sayiDizisi=new int[diziUzunlugu];

        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write("Lutfen {0}. sayiyi giriniz:",i+1);
            sayiDizisi[i]=int.Parse(Console.ReadLine());
        }

        int toplam=0;
        foreach (var sayi in sayiDizisi)
        {
            toplam+=sayi;
        }

        Console.WriteLine("Ortalama sonucu:"+toplam/diziUzunlugu);
        Console.WriteLine("Girmis oldugunuz sayi adeti: "+sayiDizisi.Length);
    }
}
