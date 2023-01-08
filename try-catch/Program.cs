namespace try_catch;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Bir sayi giriniz:");
            int sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmis oldugunuz sayi:"+sayi); 
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("Hata:"+ex.Message.ToString());
        }
        finally
        {
            Console.WriteLine("Islem tamamlandi.");
        }
      
    }
}
