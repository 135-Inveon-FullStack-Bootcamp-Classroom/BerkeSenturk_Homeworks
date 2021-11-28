using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.GenreOperations.Queries
{
    public class GetGenresQuery
    {
        private readonly MovieStoreDBContext _dbContext;
        private readonly IMapper _mapper;

        public GetGenresQuery(MovieStoreDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        // VM : view model
        public List<GenresVM> Handle()
        {
            var genres = _dbContext.Genres.ToList();

            List<GenresVM> vm = _mapper.Map<List<GenresVM>>(genres);

            return vm;           
        }
    }

    // defining the view model
    public class GenresVM
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public virtual ICollection<MovieListDTO> Movies {get;set;}
    }

    // Defining the DTO
    public class MovieListDTO
    {
        public string MovieName { get; set; }
    }
}