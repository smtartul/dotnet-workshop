namespace array_methods;
class Program
{
    static void Main(string[] args)
    {
        int [] sayiDizisi={23,12,4,86,72,3,11,17};
        Console.WriteLine("------- Sirasiz dizi ------");
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        Console.WriteLine("------- Sirali dizi ------");
        Array.Sort(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
    
        }
         Console.WriteLine("------- dizi Reverse ------");
        Array.Reverse(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
    
        }

        Console.WriteLine("------- indexOf  ------");
        int sira=Array.IndexOf(sayiDizisi,23);
        Console.WriteLine("Aradiginiz elemanin dizideki indeksi: "+sira);
   
        Console.WriteLine("------- Resize ------");
        Array.Resize<int>(ref sayiDizisi,9);
        sayiDizisi[8]=99;
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
    
        }

    }
}
