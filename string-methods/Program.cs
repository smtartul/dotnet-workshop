namespace string_methods;
class Program
{
    static void Main(string[] args)
    {
        string degisken1 = "Dersimiz Csharp, Hosgeldiniz";
        string degisken2 = "Csharp";

        //Length
        Console.WriteLine(degisken1.Length);

        //ToUpper-ToLower
        Console.WriteLine(degisken1.ToUpper());
        Console.WriteLine(degisken1.ToLower());

        //Concat-Birlestirme
        Console.WriteLine(string.Concat(degisken1," Merhaba!"));

        //Compare-CompareTo
        Console.WriteLine(string.Compare(degisken1,degisken2)); // (-1,0,1)
        Console.WriteLine(string.Compare(degisken1,degisken2,true)); // (-1,0,1)
        Console.WriteLine(string.Compare(degisken1,degisken2,false)); // (-1,0,1)
        Console.WriteLine(degisken1.CompareTo(degisken2)); // (-1,0,1)

        //Contains
        Console.WriteLine(degisken1.Contains(degisken2)); //true-false
        Console.WriteLine(degisken1.EndsWith("Hosgeldiniz")); //true-false
        Console.WriteLine(degisken1.StartsWith("Merhaba")); //true-false

        //IndexOf
        Console.WriteLine(degisken1.IndexOf("Cs")); 

        //Insert
        Console.WriteLine(degisken1.Insert(0,"Merhaba "));

        //Remove
        Console.WriteLine(degisken1.Remove(10));
        Console.WriteLine(degisken1.Remove(5,3));
        Console.WriteLine(degisken1.Remove(0,1));

        //Replace
        Console.WriteLine(degisken1.Replace("Csharp","C#"));

        //Split
        Console.WriteLine(degisken1.Split(' ')[1]);

        //Substring
        Console.WriteLine(degisken1.Substring(0,5));
        Console.WriteLine(degisken1.Substring(1));


    }
}
