namespace encapsulation;
class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci1 = new Ogrenci();
        ogrenci1.Ad = "Samet";
        ogrenci1.Soyad = "Artul";
        ogrenci1.No = 33;
        ogrenci1.Sinif = 2;
        ogrenci1.OgrenciBilgileriniGetir();

        Ogrenci ogrenci2 = new Ogrenci("Cansu", "Artul", 30, 1);
        ogrenci2.OgrenciBilgileriniGetir();

        ogrenci2.SinifDusur();
        ogrenci2.OgrenciBilgileriniGetir();

        ogrenci1.SinifArttir();
        ogrenci1.OgrenciBilgileriniGetir();
    }
}
class Ogrenci
{
    private string ad;
    private string soyad;
    private int no;
    private int sinif;



    public Ogrenci(string ad, string soyad, int no, int sinif)
    {
        Ad = ad;
        Sinif = sinif;
        No = no;
        Soyad = soyad;
    }
    public Ogrenci()
    {

    }


    public string Ad { get => ad; set => ad = value; }
    public string Soyad { get => soyad; set => soyad = value; }

    public int Sinif
    {
        get => sinif; set
        {
            if (value < 1)
            {
                Console.WriteLine("Sinif degeri 1 den kucuk olamaz!");
                sinif = 1;
            }
            else
            {
                sinif = value;
            }
        }
    }
    public int No
    {
        get => no;
        set => no = value;

    }

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("------- Ogrenci Bilgileri -------");
        Console.WriteLine("Ogrenci Adi          :{0}", this.Ad);
        Console.WriteLine("Ogrenci Soyadi       :{0}", this.Soyad);
        Console.WriteLine("Ogrenci No           :{0}", this.No);
        Console.WriteLine("Ogrenci Sinifi       :{0}", this.Sinif);
    }
    public void SinifArttir()
    {
        this.Sinif = this.Sinif + 1;
    }
    public void SinifDusur()
    {
        this.Sinif = this.Sinif - 1;
    }


}
