using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // encapsulation: protecting funcs and features from another classes
            Student student = new Student();
            student.Name = "Berke";
            student.Surname = "Şentürk";
            student.StudentNo = 1223;
            student.Year = 2;

            student.StudentInfo();
            student.LevelUpYear();
            student.StudentInfo();

            Student student2 = new Student("Melisa","Şentürk",2132,1);
            student2.StudentInfo();
            student2.LevelDownYear();
        }
    }

    class Student 
    {
        private string name;
        private string surname;
        private int studentNo;
        private int year;

        public string Name { 
            get { return name; }
            set { name = value;}
        }
        public string Surname { get => surname; set => surname = value;}   

        public int StudentNo { get => studentNo; set => studentNo = value;}   

        public int Year { 
            get => year; 
            set 
            { 
                if(value < 1)
                {
                    Console.WriteLine("year needs to bigger than 1");
                    year=1;
                }
                else {
                    year = value;
                }
            }
        }  

        public Student(string name, string surname, int studentNo, int year)
        {
            Name = name;
            Surname = surname;
            StudentNo = studentNo;
            Year = year;
        } 

        public Student(){}

        public void StudentInfo()
        {
            Console.WriteLine("name: " + this.Name);
            Console.WriteLine("surname: " + this.Surname);
            Console.WriteLine("student no: " + this.StudentNo);
            Console.WriteLine("year: " + this.Year);
        }

        public void LevelUpYear()
        {
            this.Year += 1;
        }

        public void LevelDownYear()
        {
            this.Year -= 1;
        }

    }
}
