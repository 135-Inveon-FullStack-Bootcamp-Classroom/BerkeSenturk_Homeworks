using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            forLoop();
            whileLoop();
        }

        static void forLoop()
        {
            int sayac = 20;
            for (int i=0; i <= sayac; i++)
            {
                if (i%2 == 1) //odd
                {
                    Console.WriteLine(i);
                }
            }
            
            // 1 - 1000 arası tek çift toplamı

            int tekToplam = 0;
            int ciftToplam =0;

            for (int i = 0; i <= 1000; i++)
            {
                if (i%2==1)
                    tekToplam += i;
                else {
                    ciftToplam += i;
                }

            }
            Console.WriteLine("tekler: " + tekToplam);
            Console.WriteLine("ciftler: " + ciftToplam);

            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
                
            }

        }
        static void whileLoop()
        {
            // while
            int sayi = 10;
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)

            {
                toplam += sayac;
                sayac++;     
            }
            
            Console.WriteLine(toplam/sayi);
        }
    }
}
