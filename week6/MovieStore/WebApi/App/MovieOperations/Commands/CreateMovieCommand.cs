using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.MovieOperations.Commands
{
    public class CreateMovieCommand
    {
        private readonly MovieStoreDBContext _dbContext;
        private readonly IMapper _mapper;
        public CreateMovieVM Model;    

        public CreateMovieCommand(MovieStoreDBContext dBContext, IMapper mapper)   
        {
            _dbContext = dBContext;
            _mapper = mapper;
        }
        // handler function for create Movie
        public void Handle()
        {
            var Movie = _dbContext.Movies.SingleOrDefault(x => x.MovieName == Model.MovieName);
            
            // checking new Movie already exists
            if (Movie is not null)
            {

                // if Movie exists, then it is invalid operation 
                throw new InvalidOperationException("Movie exists!");
            }

            Movie = _mapper.Map<Movie>(Model);

            // add desired Movie to the dbcontext
            _dbContext.Movies.Add(Movie);
            // save changes to the db
            _dbContext.SaveChanges();

        }
    }
    // define Movie view model
    public class CreateMovieVM
    {
        public string MovieName { get; set; }
        
    }
}
