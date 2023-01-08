namespace while_foreach;
class Program
{
    static void Main(string[] args)
    {
        // 1 den baslayarak girilen sayiya kadar (dahil) ortalam hesabi yapip konsola yazdiran kod ornegi
        Console.WriteLine("sayi giriniz:");
        int sayi=int.Parse(Console.ReadLine());
        int sayac=1;
        int toplam=0;
        while (sayac<=sayi)
        {
            toplam+=sayac;
            sayac++;
        }

        Console.WriteLine("Ortalama sonucu:"+toplam/sayi);

        Console.WriteLine("-------Foreach usage");

        string [] cars={"Bmw","Ford","Mercedes"};
        foreach (var car in cars){
            Console.WriteLine(car);
        }
        
        
    }
}
