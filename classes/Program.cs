namespace classes;
class Program
{
    static void Main(string[] args)
    {
       Calisan calisan1=new Calisan();
       calisan1.Ad="Samet"; 
       calisan1.Soyad="ARTUL"; 
       calisan1.No=33; 
       calisan1.Departman="CENG"; 
       calisan1.CalisanBilgileri();
    }
}
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisan Adi:{0}", Ad);
        Console.WriteLine("Calisan Soyadi:{0}", Soyad);
        Console.WriteLine("Calisan No:{0}", No);
        Console.WriteLine("Calisan Departmani:{0}", Departman);
    }
}
