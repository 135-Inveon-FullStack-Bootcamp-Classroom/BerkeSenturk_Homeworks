using WebApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new MovieStoreDBContext(serviceProvider.GetRequiredService<DbContextOptions<MovieStoreDBContext>>()))
            {
                // if data exists do not add any
                if (context.Movies.Any())
                {
                    return;
                }

                context.Movies.AddRange(
                    new Movie
                    {
                        MovieName = "Se7en",
                        ProductionYear = 1995,
                        Budget = "50.000.000 USD",
                        DirectorId = 1,
                        GenreId = 1,
                    },
                    new Movie 
                    {
                        MovieName = "Matrix",
                        ProductionYear = 1999,
                        Budget = "100.000.000 USD",
                        DirectorId = 2,
                        GenreId = 2,
                    },
                    new Movie
                    {
                        MovieName = "Matrix Reloaded",
                        Budget = "120.000.000 USD",
                        ProductionYear = 2003,
                        DirectorId = 2,
                        GenreId = 2,
                    }
                );
                
                context.Genres.AddRange(
                    new Genre
                    {
                        GenreName = "Crime"
                    },
                    new Genre
                    {
                        GenreName = "Sci-fi"
                    }
                );

                context.Directors.AddRange(
                    new Director
                    {
                        Name = "David",
                        Surname = "Fincher",
                        Age = 59
                    },
                    new Director
                    {
                        Name = "Lana & Lilly",
                        Surname = "Wachowski",
                        Age = 56,
                    }
                
                );

                context.Actors.AddRange(
                    new Actor
                    {
                        Name = "Keanu",
                        Surname = "Reeves",
                        Age = 42
                    },
                    new Actor
                    {
                        Name = "Brad",
                        Surname = "Pitt",
                        Age = 51
                    },
                    new Actor
                    {
                        Name = "Kevin",
                        Surname = "Spacey",
                        Age = 37

                    },
                    new Actor
                    {
                        Name = "Morgan",
                        Surname = "Freeman",
                        Age = 77
                    },
                    new Actor
                    {
                        Name = "Carrie-Anne",
                        Surname = "Moss", 
                        Age = 48
                    },
                    new Actor
                    {
                        Name = "Laurence",
                        Surname = "Fishburne",
                        Age = 62
                    }
                );

                context.Cast.AddRange(
                    new Cast
                    {
                        ActorId = 1,
                        MovieId =2,
                    },
                    new Cast
                    {
                        ActorId = 1,
                        MovieId = 3,
                    },
                    new Cast
                    {
                        ActorId = 2,
                        MovieId = 1,
                    },
                    new Cast
                    {
                        ActorId = 3,
                        MovieId = 1,
                    },
                    new Cast
                    {
                        ActorId = 4,
                        MovieId = 1,
                    },
                    new Cast
                    {
                        ActorId = 5,
                        MovieId = 2,
                    },
                    new Cast
                    {
                        ActorId = 5,
                        MovieId = 3,
                    },
                    new Cast
                    {
                        ActorId = 6,
                        MovieId = 3
                    }
                );

                context.SaveChanges();
            }
        }
    }
}