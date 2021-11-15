using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee();
            
            employee1.Name = "Berke";
            employee1.Surname = "Senturk";
            employee1.No = 142352342;
            employee1.Department = "IT";

            employee1.EmployeeInformations();
            
            Employee employee2 = new Employee();
            
            employee2.Name = "Melisa";
            employee2.Surname = "Senturk";
            employee2.No = 142352343;
            employee2.Department = "Retail";

            employee2.EmployeeInformations();

            Employee employee3 = new Employee("Sedat","Şentürk",5555555,"Retail");
            employee3.EmployeeInformations();

            Employee employee4 = new Employee("Türkan","Şentürk");
            employee4.EmployeeInformations();

        }
    }

    class Employee
    {
        public string Name;
        public string Surname;
        public int No;
        public string Department;

        public Employee(string name, string surname, int no, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.No = no;
            this.Department = department;
        }

        public Employee(string name, string surname){
            this.Name = name;
            this.Surname = surname;
        }

        public Employee(){}
        public void EmployeeInformations(){
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Surname: {0}", Surname);
            Console.WriteLine("No: {0}", No);
            Console.WriteLine("Department: {0}", Department);
        }
    }
}


 