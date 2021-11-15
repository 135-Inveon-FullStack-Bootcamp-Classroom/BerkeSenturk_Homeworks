using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // +
            int x= 3;
            int y=2 ;
            int z = x+y;
            Console.WriteLine(z);

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect");

            if(isSuccess || isCompleted)
                Console.WriteLine("Great");
            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine");

            // operators

            int a= 3;
            int b=4;

            bool sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

        }
    }
}
