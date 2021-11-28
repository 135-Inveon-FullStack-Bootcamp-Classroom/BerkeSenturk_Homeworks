using WebApi.DBOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.GenreOperations.Commands
{
    public class UpdateGenreCommand
    {
        private readonly MovieStoreDBContext _dbContext;
        public int GenreId { get; set; }
        public UpdateGenreVM Model { get; set; }

        public UpdateGenreCommand(MovieStoreDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        // handler function for update Genre
        public void Handle()
        {
            var genre = _dbContext.Genres.SingleOrDefault(x => x.GenreId == GenreId);

            if (genre is null)
            {
                // if Genre is not exist, then it is a invalid operation
                throw new InvalidOperationException("Genre not found!");
            }

            // update props
            genre.GenreName = Model.GenreName;

            _dbContext.SaveChanges();
        }
    }

    public class UpdateGenreVM
    {
        public string GenreName { get; set; }
    }
}
