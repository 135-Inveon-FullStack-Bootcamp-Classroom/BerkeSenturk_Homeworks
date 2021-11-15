using System;

namespace try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            // try catch finally

            try {
                Console.WriteLine("bir sayı gir: ");

                int sayi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("input is: " + sayi);
            }

            catch(Exception ex) 
            {
                Console.WriteLine("hata: " + ex.Message.ToString());
            }
            finally 
            {
                Console.WriteLine("process is completed");
            }
            try
            {
                // int a = int.Parse(null);
                int a = int.Parse("test");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("empty value input");
                Console.WriteLine(ex);
                
            }

            catch(FormatException ex) {
                Console.WriteLine("wrong data format");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex) {
                Console.WriteLine("too small or too big value");
                Console.WriteLine(ex);

            }
            finally{
                Console.WriteLine("process compoleted successfully");
            }
        }
    }
}
