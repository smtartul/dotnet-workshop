namespace method_overloading;
class Program
{
    static void Main(string[] args)
    {
        string sayi = "999";

        bool result = int.TryParse(sayi, out int outSayi);
        if (result)
        {
            Console.WriteLine("Basarili!");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Basarisiz!");
        }

        Methods instance = new();
        instance.Topla(4, 5, out int toplamSonucu);
        Console.WriteLine(toplamSonucu);

        int ifade = 999;
        instance.EkranaYazdir(ifade);
    }
}
class Methods
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;

    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }

}
