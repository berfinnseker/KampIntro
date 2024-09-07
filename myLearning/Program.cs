using System;

namespace myLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
 /*
            //var sonuc = kosul ? deger1 : deger2;(ternay öperatörü)
            int i = 1;
            var sonuc = i > 10 ? "evet" : "hayır";
*/
            string[] name =
            {
              "person1","person2","person3"
            };
            foreach(string person  in name)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine("Lütfen bir sayı giriniz");
            //parse consoldan gireceğimiz string olarak görülen ifadeyi int yapısına dönüştürür.
            int sayi=int.Parse(Console.ReadLine());
            switch(sayi) 
            {
            case 1:Console.WriteLine("Pazartesi");break;
            case 2: Console.WriteLine("Salı"); break;
            case 3: Console.WriteLine("Çarşamba"); break;
            case 4: Console.WriteLine("Perşembe"); break;
            case 5: Console.WriteLine("Cuma"); break;
            case 6: Console.WriteLine("Cumartesi"); break;
            case 7: Console.WriteLine("Pazar"); break;

                default: Console.WriteLine("Hata böyle bir gün yoktur");break;
            }
            int a = 0;
            while (a<10)
            {
                Console.WriteLine(a);
                a++;
                
            }

        }
    }
}
