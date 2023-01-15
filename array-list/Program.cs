using System.Collections;

namespace array_list;
class Program
{
    static void Main(string[] args)
    {
        ArrayList arr = new ArrayList();
        arr.Add("Ali");
        arr.Add(2);
        arr.Add(true);
        arr.Add('a');

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("------ AddRange ----");
        string[] renkler ={
            "Kirmizi",
            "Mavi",
            "Yesil"
        };
        arr.AddRange(renkler);

        List<int> sayilar = new List<int>(){
            1,10,25,4,7
        };

        arr.AddRange(sayilar);

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}
