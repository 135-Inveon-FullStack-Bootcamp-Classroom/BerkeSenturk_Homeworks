using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.DirectorOperations.Queries
{
    public class GetDirectorsQuery
    {
        private readonly MovieStoreDBContext _dbContext;
        private readonly IMapper _mapper;

        public GetDirectorsQuery(MovieStoreDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        // VM : view model
        public List<DirectorsVM> Handle()
        {
            var directors = _dbContext.Directors.ToList();

            List<DirectorsVM> vm = _mapper.Map<List<DirectorsVM>>(directors);

            return vm;           
        }
    }

    // defining the view model
    public class DirectorsVM
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Movie> Casts { get; set; }
    }
}