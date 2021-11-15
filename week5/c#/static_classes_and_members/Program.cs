using System;

namespace static_classes_and_members
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("employee number: {0}", Employee.EmployeePopulation);

            Employee employee = new Employee("Berke", "Şentürk", "IT");

            Console.WriteLine("employee number: {0}", Employee.EmployeePopulation);
        }
    }
    class Employee
    {
        private static int employeePopulation;

        public static int EmployeePopulation { get => employeePopulation; }

        private string Name;
        private string Surname;

        private string Department;

        static Employee()
        {
            employeePopulation = 0;
        }

        public Employee(string name, string surname, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
            employeePopulation ++;
        }
    }
}
