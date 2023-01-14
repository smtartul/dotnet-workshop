namespace _04_task4;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lutfen bir cumle yaziniz");
        string cumle=Console.ReadLine();

        string [] arr=cumle.Split(' ');
        string words=string.Join("",arr);
        int kelimeAdet=arr.Count();
        int harfAdet=words.Length;
        if(harfAdet==0){
            kelimeAdet=0;
        }
        
        Console.WriteLine("Cumledeki toplam harf sayisi: "+harfAdet);
        Console.WriteLine("Cumledeki toplam kelime sayisi: "+kelimeAdet);
        

    }
}
