using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"Yazılım geliştirici yetiştirme kampı","Programlamaya başlangıç","java","python","c" };

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string kurs in kurslar)
            {
                
            }

         /*switch(koşul)
         {
         case deger1:   Değer Bire Göre Yapılacak işlemler;    break;
         case deger2:   Değer İkiye Göre Yapılacak işlemler;    break;
         case deger3:   Değer Üçe Göre Yapılacak işlemler;    break;
         case deger4:   Değer Dörde Göre Yapılacak işlemler;    break;
         .
         .
         .
         default:    Verilen Koşul Hiç Bir Değere Uymadığında Yapılacak işlemler;     
         break;}
         */
        }
    }
}
