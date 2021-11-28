using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.ActorOperations.Queries
{
    public class GetActorsQuery
    {
        private readonly MovieStoreDBContext _dbContext;
        private readonly IMapper _mapper;

        public GetActorsQuery(MovieStoreDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        // VM : view model
        public List<ActorsVM> Handle()
        {
            var actors = _dbContext.Actors.ToList();

            List<ActorsVM> vm = _mapper.Map<List<ActorsVM>>(actors);

            return vm;           
        }
    }

    // defining the view model
    public class ActorsVM
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<CastMoviesDTO> Casts { get; set; }
    }

    // Defining the DTO
    public class CastMoviesDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}