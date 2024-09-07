using System;

namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 30;
            //sayi1 ?? 20

            int[] sayilar1 = new int[] {10,20,30};
            int[] sayilar2 = new int[] {40,50,60};
            sayilar1 = sayilar2;//sayilar1'in referans numarası sayilar2'nin referans numarasına eşittir.
            sayilar2[0] = 99;
            //sayilar1[0] ?? 99


            //int,double,decimal,float,bool=VALUE TYPE
            //array,class,interface=REFERENCE TYPE

            //Bellekte stack ve heap olmak üzere 2 tane yerimiz vardır.Value type Stack'te gerçekleşir.
            //array lar heap te tutulur.stack'te sayilar1 tutulurken array'ımız heap'te tutulur.


        }
    }
}
