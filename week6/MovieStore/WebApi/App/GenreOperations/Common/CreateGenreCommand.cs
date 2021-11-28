using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.GenreOperations.Commands
{
    public class CreateGenreCommand
    {
        private readonly MovieStoreDBContext _dbContext;
        private readonly IMapper _mapper;
        public CreateGenreVM Model;    

        public CreateGenreCommand(MovieStoreDBContext dBContext, IMapper mapper)   
        {
            _dbContext = dBContext;
            _mapper = mapper;
        }
        // handler function for create Genre
        public void Handle()
        {
            var Genre = _dbContext.Genres.SingleOrDefault(x => x.GenreName == Model.GenreName);
            
            // checking new Genre already exists
            if (Genre is not null)
            {

                // if Genre exists, then it is invalid operation 
                throw new InvalidOperationException("Genre exists!");
            }

            Genre = _mapper.Map<Genre>(Model);

            // add desired Genre to the dbcontext
            _dbContext.Genres.Add(Genre);
            // save changes to the db
            _dbContext.SaveChanges();

        }
    }
    // define Genre view model
    public class CreateGenreVM
    {
        public string GenreName { get; set; }
    }

}
