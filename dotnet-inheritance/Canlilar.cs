using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_inheritance
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlilar beslenir!");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlilar solunum yapar!");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Canlilar bosaltim yapar");
        }
    }
}