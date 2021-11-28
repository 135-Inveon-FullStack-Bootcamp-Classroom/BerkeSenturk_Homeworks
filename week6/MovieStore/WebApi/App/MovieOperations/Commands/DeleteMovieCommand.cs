using WebApi.DBOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.MovieOperations.Commands
{
    public class DeleteMovieCommand
    {
        private readonly MovieStoreDBContext _dbContext;
        public int MovieId { get; set; }

        public DeleteMovieCommand(MovieStoreDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        // handler function for delete Movie
        public void Handle()
        {
            var movie = _dbContext.Movies.SingleOrDefault(x => x.MovieId == MovieId);
            
            // if Movie is not exist, then it is a invalid operation
            if (movie is null)
            {
                throw new InvalidOperationException("Movie not found!");
            }

            // remove Movie from the dbcontext
            _dbContext.Movies.Remove(movie);
        
            // finally save the changes
            _dbContext.SaveChanges();
        }
    }
}