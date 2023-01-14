namespace recursive_extension;
class Program
{
    static void Main(string[] args)
    {
        Islemler instance = new();
        Console.WriteLine(instance.Expo(3, 4));

        string ifade = "Samet ARTUL";
        bool result = ifade.CheckSpaces();
        Console.WriteLine(result);
        if (result)
        {
            Console.WriteLine(ifade.RemoveWhiteSpaces());
        }
        Console.WriteLine(ifade.ToUpper());
        Console.WriteLine(ifade.ToLower());

        int[] dizi={9,3,6,2,1,5,0};
        dizi.SortArray();
        dizi.EkranaYazdir();

        int deger1=3;
        Console.WriteLine(deger1.IsEven());

        Console.WriteLine(ifade.GetFirstChar());
    }
}
public class Islemler
{
    public int Expo(int alt, int exp)
    {
        if (exp < 2) return alt;
        return Expo(alt, exp - 1) * alt;

    }
}
//extension class must be static!!
public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }
    public static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("", dizi);
    }
    public static string ToUpper(this string param)
    {
        return param.ToUpper();
    }
    public static string ToLower(this string param)
    {
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param){
        Array.Sort(param);
        return param;
    }

    public static void EkranaYazdir(this int[] param){
        foreach (var item in param)
        {
            Console.WriteLine(item);
        }
    }

    public static bool IsEven(this int param){
        return param%2==0;
    }

    public static string GetFirstChar(this string param){
        return param.Substring(0,1);
    }
}

