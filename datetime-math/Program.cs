namespace datetime_math;
class Program
{
    static void Main(string[] args)
    {

        // --------- DATETIME --------- 

        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.ToString("dd"));//15
        Console.WriteLine(DateTime.Now.ToString("ddd"));//Sun
        Console.WriteLine(DateTime.Now.ToString("dddd"));//Sunday

        Console.WriteLine(DateTime.Now.ToString("MM"));//01
        Console.WriteLine(DateTime.Now.ToString("MMM"));//Jan
        Console.WriteLine(DateTime.Now.ToString("MMMM"));//January

        Console.WriteLine(DateTime.Now.ToString("yy"));//23
        Console.WriteLine(DateTime.Now.ToString("yyyy"));//2023

        Console.WriteLine(DateTime.Now.ToString("mm/dd/yyyy HH:mm:ss"));//24H
        Console.WriteLine(DateTime.Now.ToString("mm/dd/yyyy hh:mm:ss"));//12H
        Console.WriteLine(DateTime.Now.ToString("mm/dd/yyyy hh:mm:ss tt"));//12H AM-PM

        // --------- MATH --------- 
        Console.WriteLine(Math.Abs(-25));//25
        Console.WriteLine(Math.Sin(45));
        Console.WriteLine(Math.Cos(45));
        Console.WriteLine(Math.Tan(45));

        Console.WriteLine(Math.Ceiling(22.7));//23
        Console.WriteLine(Math.Floor(22.7));//22
        Console.WriteLine(Math.Round(22.7));//23
        Console.WriteLine(Math.Round(22.3));//22

        Console.WriteLine(Math.Max(10,15));//15
        Console.WriteLine(Math.Min(10,15));//10

        Console.WriteLine(Math.Pow(2,4));//2ˆ4
        Console.WriteLine(Math.Sqrt(9));//3
        Console.WriteLine(Math.Log(9));
        Console.WriteLine(Math.Exp(3));//eˆ3

    }
}
