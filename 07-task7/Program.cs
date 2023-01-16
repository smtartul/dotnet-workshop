namespace _07_task7;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lutfen bir cumle giriniz:");
        string str = Console.ReadLine();
        string str2 = "aeıioöuü";
        List<char> arr = new List<char>();
        for (int i = 0; i < str.Length; i++)
        {
            if (str2.Contains(str[i]))
            {
                arr.Add(str[i]);
            }
        }
        if (arr.Count <= 0)
        {
            Console.WriteLine("Girmis oldugunuz cumlede sesli harf mevcut degildir!");
        }
        else
        {
            Console.WriteLine("Girmis oldugunuz cumlenin sesli harfleri sirali sekilde:");
            arr.Sort();
            arr.ForEach(s => Console.WriteLine(s));
        }

    }
}
