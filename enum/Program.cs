namespace enumTutorial;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Gunler.Pazartesi);
        Console.WriteLine((int)Gunler.Pazar);
    }
}

enum Gunler
{
    Pazartesi,
    Sali,
    Carsamba,
    Persembe,
    Cuma,
    Cumartesi,
    Pazar
}
