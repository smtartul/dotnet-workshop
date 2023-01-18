using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_inheritance
{
    public class Bitkiler : Canlilar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler fotosentez yapar");
        }
    }
    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla cogalir");
        }
    }
    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla cogalir!");
        }
    }
}