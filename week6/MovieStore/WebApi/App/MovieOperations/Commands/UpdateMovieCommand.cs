using WebApi.DBOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.MovieOperations.Commands
{
    public class UpdateMovieCommand
    {
        private readonly MovieStoreDBContext _dbContext;
        public int MovieId { get; set; }
        public UpdateMovieVM Model { get; set; }

        public UpdateMovieCommand(MovieStoreDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        // handler function for update Movie
        public void Handle()
        {
            var movie = _dbContext.Movies.SingleOrDefault(x => x.MovieId == MovieId);

            if (movie is null)
            {
                // if Movie is not exist, then it is a invalid operation
                throw new InvalidOperationException("Movie not found!");
            }

            // update props
            movie.MovieName = Model.MovieName;
            movie.ProductionYear = Model.ProductionYear;
            movie.Budget = Model.Budget;
            movie.GenreId = Model.GenreId;
            

            _dbContext.SaveChanges();
        }
    }

    public class UpdateMovieVM
    {
        public string MovieName { get; set; }
        public int ProductionYear { get; set; }
        public string Budget { get; set; }
        public int GenreId { get; set; }
        public int DirectorId { get; set; }
        public string Actors { get; set; }
    }
}
