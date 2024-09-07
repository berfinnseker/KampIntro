using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";
            */
            string[] meyveler = new string[] { };

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explain = "Amasya elması";
            product1.Stock = 25;


            Product product2 = new Product();
            product2.Name = "Kiraz";
            product2.Price = 25;
            product2.Explain = "Tatlı";
            product2.Stock = 15;

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products) 
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explain);
                Console.WriteLine(product.Stock);
                Console.WriteLine("------------");

            }
            Console.WriteLine("--------Metodlar---------");
            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Ayva","tatlı",30,10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 21,13);
        }
    }
}
