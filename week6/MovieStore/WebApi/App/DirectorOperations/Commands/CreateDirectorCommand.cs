using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.DirectorOperations.Commands
{
    public class CreateDirectorCommand
    {
        private readonly MovieStoreDBContext _dbContext;
        private readonly IMapper _mapper;
        public CreateDirectorVM Model;    

        public CreateDirectorCommand(MovieStoreDBContext dBContext, IMapper mapper)   
        {
            _dbContext = dBContext;
            _mapper = mapper;
        }
        // handler function for create Director
        public void Handle()
        {
            var director = _dbContext.Directors.SingleOrDefault(x => x.Name == Model.Name);
            
            // checking new Director already exists
            if (director is not null)
            {

                // if Director exists, then it is invalid operation 
                throw new InvalidOperationException("Director exists!");
            }

            director = _mapper.Map<Director>(Model);

            // add desired Director to the dbcontext
            _dbContext.Directors.Add(director);
            // save changes to the db
            _dbContext.SaveChanges();

        }
    }
    // define Director view model
    public class CreateDirectorVM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }    
    }
}
