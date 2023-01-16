namespace classes;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------- Calisan1 -------");
        Calisan calisan1 = new Calisan();
        calisan1.Ad = "Samet";
        calisan1.Soyad = "ARTUL";
        calisan1.No = 1101;
        calisan1.Departman = "Yonetici";
        calisan1.CalisanBilgileri();

        Console.WriteLine("---------- Calisan2 -------");
        Calisan calisan2=new Calisan("Arel","ARTUL",2201,"Satis");
        calisan2.CalisanBilgileri();
        Console.WriteLine("---------- Calisan3 -------");
        Calisan calisan3=new Calisan("Cansu","ARTUL");
        calisan3.CalisanBilgileri();
    }
}
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan()
    {

    }
    public Calisan(string ad, string soyad, int no, string departman)
    {
        Ad = ad;
        Soyad = soyad;
        No = no;
        Departman = departman;
    }
    public Calisan(string ad, string soyad)
    {
        Ad = ad;
        Soyad = soyad;
    }
    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisan Adi:{0}", Ad);
        Console.WriteLine("Calisan Soyadi:{0}", Soyad);
        Console.WriteLine("Calisan No:{0}", No);
        Console.WriteLine("Calisan Departmani:{0}", Departman);
    }
}
