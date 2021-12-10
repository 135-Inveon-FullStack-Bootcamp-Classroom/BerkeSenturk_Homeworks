
using System.Collections.Generic;
using System.Linq;
using WebApi.DBOperations;
using WebApi.Common;
using System;

namespace WebApi.GenreOperations.CreateGenre
{
    public class CreateGenreCommand
    {
        public CreateGenreModel Model { get; set; }
        private readonly ApplicationDbContext _dbContext;
        
        public CreateGenreCommand(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle()
        {
            var Genre = _dbContext.Genres.SingleOrDefault(x => x.Title == Model.Title);

            if(Genre is not null)
                throw new InvalidOperationException("Genre exists already.");

            Genre = new Genre();
            Genre.Title = Model.Title;

            _dbContext.Genres.Add(Genre);
            _dbContext.SaveChanges();
            
        }

        public class CreateGenreModel
        {
            public string Title { get; set; }
        }
    }
}