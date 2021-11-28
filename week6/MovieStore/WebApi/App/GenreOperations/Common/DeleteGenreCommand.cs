using WebApi.DBOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.GenreOperations.Commands
{
    public class DeleteGenreCommand
    {
        private readonly MovieStoreDBContext _dbContext;
        public int GenreId { get; set; }

        public DeleteGenreCommand(MovieStoreDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        // handler function for delete Genre
        public void Handle()
        {
            var genre = _dbContext.Genres.SingleOrDefault(x => x.GenreId == GenreId);
            
            // if Genre is not exist, then it is a invalid operation
            if (genre is null)
            {
                throw new InvalidOperationException("Genre not found!");
            }

            // remove Genre from the dbcontext
            _dbContext.Genres.Remove(genre);
        
            // finally save the changes
            _dbContext.SaveChanges();
        }
    }
}