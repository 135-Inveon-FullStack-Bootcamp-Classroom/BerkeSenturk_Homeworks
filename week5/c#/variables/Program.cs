using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int integer1= 5;
            int integer2 = 7;
            int integer3= integer1 + integer2;

            bool bool1= 10 > 2;

            int int20=20;
            string str20= "20";

            string newVal = str20 + int20.ToString();

            int int21 = int20 + Convert.ToInt32(str20);

            Console.WriteLine(newVal);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22);

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");

            Console.WriteLine(datetime);
        }
    }
}
