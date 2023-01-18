using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_inheritance
{
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir");
        }
    }
    public class Surungenler : Hayvanlar
    {
        public Surungenler()
        {
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.Adaptasyon();
        }
        public void Surunme()
        {
            Console.WriteLine("Surungenler surunerek hareket eder!");
        }
    }
    public class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.Adaptasyon();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuslar ucar!");
        }
    }
}