using System;

namespace conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if-else\n----");
            ifElse();
            Console.WriteLine("----\nswitch-case\n----");
            switchCase();
        }
        static void ifElse(){

            int time = DateTime.Now.Hour;

            if(time>=6 && time<11)
                Console.WriteLine("günaydın");

            else if(time<=18)
                Console.WriteLine("iyi günler");
            
            else 
                Console.WriteLine("iyi geceler");
            
            string sonuc = time<=18 ? "iyi günler" : "iyi geceler";

            sonuc = time>=6 && time<11 ? "günaydın" : time<=18 ? "iyi günler" : "iyi geceler";
            Console.WriteLine(sonuc);
        }
        static void switchCase(){

        }
    }
}
