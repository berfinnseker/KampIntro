using System;
using System.Diagnostics.Tracing;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "java";
            kurs1.Egitmen = "engin";
            kurs1.İzlenmeOrani = 65;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "python";
            kurs2.Egitmen = "berfin";
            kurs2.İzlenmeOrani = 70;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "c++";
            kurs3.Egitmen = "ferhat";
            kurs3.İzlenmeOrani = 75;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen +" "+ kurs.İzlenmeOrani);
            }

  


        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }

    }
}
