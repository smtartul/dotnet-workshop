﻿namespace switch_case;
class Program
{
    static void Main(string[] args)
    {
        int month=DateTime.Now.Month;
        switch (month)
        {
            case 1:
                Console.WriteLine("Ocak Ayindasiniz");
                break;
            case 2:
                Console.WriteLine("Subat ayindasiniz");
                break;
            default:
                Console.WriteLine("Yanlis giris yaptiniz.");
                break;
        }

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kis mevsimindesiniz");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Ilkbahar mevsimindesiniz");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Yaz mevsimindesiniz");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sonbahar mevsimindesiniz");
                break;
            default:
            Console.WriteLine("Yanlis giris yaptiniz");
            break;
        }
    }
}
