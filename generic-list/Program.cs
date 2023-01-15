namespace generic_list;
class Program
{
    static void Main(string[] args)
    {
        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi = new List<string>();
        renkListesi.Add("Kirmizi");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sari");
        renkListesi.Add("Yesil");


        //Count
        Console.WriteLine(sayiListesi.Count);
        Console.WriteLine(renkListesi.Count);

        //Foreach
        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        //Remove
        sayiListesi.Remove(34);
        renkListesi.Remove("Yesil");

        //RemoveAt - index
        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);

        //Contains
        bool result = sayiListesi.Contains(4) ? true : false;
        Console.WriteLine(result);

        //BinarySearch
        
        Console.WriteLine("Aradiginiz eleman {0}.indextedir",renkListesi.BinarySearch("Turuncu"));
        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        //Diziyi listeye cevirme
        string[] hayvanArr={"Kedi","Kopek","At"};
        List<string> hayvanListesi=new List<string>(hayvanArr);

        //Clear
        hayvanListesi.Clear();

        //Generic liste
        List<Kullanicilar> users=new List<Kullanicilar>();
        Kullanicilar user=new Kullanicilar();
        user.Ad="Samet";
        user.Soyad="Artul";
        user.Age=34;

        Kullanicilar user2=new Kullanicilar();

        user2.Ad="Arel";
        user2.Soyad="Artul";
        user2.Age=2;
        users.Add(user);
        users.Add(user2);

        users.ForEach(user=>{
            Console.WriteLine(user.Ad);
            Console.WriteLine(user.Soyad);
            Console.WriteLine(user.Age);
        });
    }

    public class Kullanicilar{
        string ad;
        string soyad;
        int age;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int Age { get => age; set => age = value; }
    }
}