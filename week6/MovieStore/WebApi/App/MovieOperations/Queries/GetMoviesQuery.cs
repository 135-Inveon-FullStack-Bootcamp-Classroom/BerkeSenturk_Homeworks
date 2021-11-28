using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.MovieOperations.Queries
{
    public class GetMoviesQuery
    {
        private readonly MovieStoreDBContext _dbContext;
        private readonly IMapper _mapper;

        public GetMoviesQuery(MovieStoreDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        // view model
        public List<MoviesVM> Handle()
        {
            var movies = _dbContext.Movies.ToList();

            List<MoviesVM> vm = _mapper.Map<List<MoviesVM>>(movies);

            return vm;
        }
    }

    public class MoviesVM
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int ProductionYear { get; set; }
        public string Budget { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public ICollection<MovieCastDTO> Casts { get; set; }

    }


    // defining the dto 
    public class MovieCastDTO
    {
        public string MovieName { get; set; }
        public int ProductionYear { get; set; }
        public string Budget { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
    }    
    
}