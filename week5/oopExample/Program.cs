using System;

namespace oopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            It itGuy = new It(){
                                 name = "Berke", surname="Şentürk", 
                                 age = 23, phone = 55546454666, 
                                 mailAddress = "abc@gmail.com", department = "IT",
                                 shift = "Wednesday until 9 AM.", title = "System Admin", 
                                 section = "System"
                                };
            
            Console.WriteLine("----IT GUY :)---");
            itGuy.shiftInfo();
            itGuy.developSystem();
            Console.WriteLine("----------------");

            Security securityGuy = new Security() {
                                                    name = "Nihal", surname = "Yılmaz",
                                                    age = 35, phone = 55546454667,
                                                    mailAddress = "sec@abc.edu.tr",
                                                    shift = "none", doorNo= 1, card="standard"
                                                  };
            Console.WriteLine("----Security GUY---");
            securityGuy.enter();
            securityGuy.shiftInfo();
            Console.WriteLine("-------------------");
        
            Assistant assistantGuy = new Assistant() 
            {
                name = "Yılmaz", surname = "Koç", age= 52, phone = 55546454668,
                mailAddress = "assist@abc.edu.tr", title = "Ass. Doc.",
                officeHour = "Wednesday from 15.00 to 18.00"
            };

            Console.WriteLine("----Assistant GUY---");
            assistantGuy.giveLecture();
            assistantGuy.cafeteria();
            Console.WriteLine("-------------------");

            Lecturer lecturerGuy = new Lecturer()
            {
                name = "Ismet", surname = "Doğan", age= 42, phone = 55546454669,
                mailAddress = "lec@abc.edu.tr", title = "Prof. Dr.", classNo = 34
            };

            Console.WriteLine("----Lecturer GUY---");
            lecturerGuy.makeExam(lecturerGuy.classNo);
            lecturerGuy.giveLecture();
            lecturerGuy.cafeteria();
            Console.WriteLine("-------------------");

        }
    }
}
