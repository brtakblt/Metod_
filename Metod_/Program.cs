namespace Metod_
{
    using System;
    using System.Net.WebSockets;

    class Program
    {
        static int[] sayilar; 

        static void Main(string[] args)
        {
            SayiUret();
            DiziYazdır();
            EnBuyukDeger();
            EnKucukDeger();
        }

        static void SayiUret()
        {
            Random r = new Random();
            sayilar = new int[10];
            try
            {
                Console.WriteLine("Küçük değer:");
                int deger1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Büyük değer:");
                int deger2 = Convert.ToInt32(Console.ReadLine());
                try
                {
                    for (int i = 0; i < sayilar.Length; i++)
                    {
                        int aralik = r.Next(deger1, deger2);
                        sayilar[i] = aralik;
                    }
                }
                catch (System.ArgumentOutOfRangeException e)
                {

                    Console.WriteLine("Küçük değer büyük değerden büyük olamaz") ;
                    Console.WriteLine(e);
                }
                
            }
            catch (System.FormatException m)
            {
                Console.WriteLine("Sayı girmelisiniz");
                Console.WriteLine(m);
                
            }
           
        }

        static void DiziYazdır()
        {
            Console.WriteLine("------>");
            foreach (int item in sayilar)
            {
                Console.WriteLine(item); 
            }
        }
        static void EnBuyukDeger()
        {
            int enBuyuk = sayilar[0];
            foreach (int sayi in sayilar)
            {
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi; 
                }
            }
            Console.WriteLine("------>"+enBuyuk);
        }
        static void EnKucukDeger()
        {
            int enKucuk = sayilar[0];
            foreach (int sayi in sayilar)
            {
                if(sayi < enKucuk)
                {
                    enKucuk = sayi;
                }
            }
            Console.WriteLine("------>"+enKucuk);
        }
    }
}
