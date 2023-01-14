namespace methods;
class Program
{
    static void Main(string[] args)
    {
        int a=2,b=3;
        methodlar ornek =new();
        ornek.EkranaYazdir(Convert.ToString(topla(a,b)));

        int sonuc=ornek.ArttirVeTopla(a,b);
        ornek.EkranaYazdir(Convert.ToString(sonuc));
    }

    static int topla(int sayi1,int sayi2){
        return sayi1+sayi2;
    }
}
class methodlar
{
    public void EkranaYazdir(string param){
        Console.WriteLine(param);
        }
    public int ArttirVeTopla(int deger1,int deger2){
        deger1++;
        deger2++;
        return (deger1+deger2);
    }
}
