using System.Linq;

namespace LinqPractices.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize()
        {
            using(var context = new LinqDbContext())
            {
                if(context.Students.Any())
                {
                    return;
                }
                context.Students.AddRange(
                    new Student()
                    {
                        StudentId = 1,
                        Name = "Berke",
                        Surname = "Şentürk",
                        ClassId = 1,
                    },
                    new Student()
                    {
                        StudentId = 2,
                        Name = "Melisa",
                        Surname = "Şentürk",
                        ClassId = 2
                    },
                    new Student()
                    {
                        StudentId = 3,
                        Name = "Ahmet",
                        Surname = "Yılmaz",
                        ClassId = 2
                    },
                    new Student()
                    {
                        StudentId = 4,
                        Name = "Mehmet",
                        Surname = "Yılmaz",
                        ClassId = 3
                    }
                );

                context.SaveChanges();
            }
        }
    }
}