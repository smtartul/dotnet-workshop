namespace for_loop;
class Program
{
    static void Main(string[] args)
    {
        // ekrandan girilen sayiya kadar olan cift sayilari ekrana yazdir
        Console.WriteLine("lutfen bir sayi giriniz");
        int sayac=int.Parse(Console.ReadLine());

        for (int i = 1; i <= sayac; i++)
        {
            if(i%2==0)
            Console.WriteLine(i);
        }
    }
}
