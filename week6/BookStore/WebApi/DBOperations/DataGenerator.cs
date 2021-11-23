using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if(context.Books.Any())
                { 
                    return;
                }

                context.Books.AddRange(
                
                    new Book{
                        Id = 1,
                        Title = "Lean Startup",
                        GenreId = 1, // Personal Growth 
                        PageCount = 200,
                        PublishDate = new System.DateTime(2001,06,12)
                    },
                    new Book{
                        Id = 2,
                        Title = "Herland",
                        GenreId = 2, // Sci-fi 
                        PageCount = 400,
                        PublishDate = new System.DateTime(2011,03,09)
                    },
                    new Book{
                        Id = 3,
                        Title = "Dune",
                        GenreId = 2, // Sci-fi 
                        PageCount = 300,
                        PublishDate = new System.DateTime(2012,05,17)
                    });
                context.SaveChanges();
            }
        }
    }
}