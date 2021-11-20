using System;
using System.Collections.Generic;
using System.Text;

namespace oopExample
{
    public abstract class Employee
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public long phone { get; set; }
        public string mailAddress { get; set; }
        public string department { get; set; }

        public void enter()
        {   
            Console.WriteLine("Employee enters the school!");
        }

        public void cafeteria()
        {
            Console.WriteLine("Employee uses the cafeteria!");
        }
    }

    public abstract class Academician : Employee
    {
        public string title { get; set; }

        public void giveLecture()
        {
            Console.WriteLine("I'm giving lecture as an Academician!");
        }
        public void cafeteria(string section)
        {
            Console.WriteLine("I'm having the meal at {0}", section);
        }

    }
    public abstract class Officer : Employee
    {
        public string shift { get; set; }
        public int doorNo { get; set; }

        public void work(string shift)
        {
            Console.WriteLine("As an officer, working with the {0}!", shift);
        }
        public void enter(int doorNo)
        {
            Console.WriteLine("As an officer, I enter the campus from the {0} door number", doorNo);
        }


    }
    class Lecturer : Academician
    {
        public int classNo { get; set; }

        public void makeExam(int classNo)
        {
            Console.WriteLine("As a lecturer, I make exam at class number: {0}", classNo);
        }
    }
    class Assistant : Academician
    {
        public string officeHour { get; set; }

        public void giveLecture()
        {
            Console.WriteLine("I'm giving lecture as an Assistant!");
        }
    }
    class It : Officer
    {  
        public string title { get; set; }
        public string section { get; set; }
        
        public string shift { get; set; }

        public void developSystem()
        {
            Console.WriteLine("As an IT member, I develop the infrastructure of the university consistently!");
        }
        public void shiftInfo()
        
        {
            if (shift != "none")
            {
                Console.WriteLine("As an IT member, my next shift will be on {0}", shift);
            }
            else {
                Console.WriteLine("No shifts assigned!");
            }
        }

        
    }
    class Security : Officer
    {
        public string card { get; set; }

        public void enter()
        {
            Console.WriteLine("As a security crew member, I enter to the campus from door {0} with the {1} card!", doorNo, card);
        }
        
        public void shiftInfo()
        
        {
            if (shift != "none")
            {
                Console.WriteLine("As a security crew member, my next shift will be on {0}", shift);
            }
            else {
                Console.WriteLine("No shifts assigned!");
            }

        }

    }

}