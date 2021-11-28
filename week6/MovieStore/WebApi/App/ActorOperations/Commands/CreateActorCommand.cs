using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.ActorOperations.Commands
{
    public class CreateActorCommand
    {
        private readonly MovieStoreDBContext _dbContext;
        private readonly IMapper _mapper;
        public CreateActorVM Model;    

        public CreateActorCommand(MovieStoreDBContext dBContext, IMapper mapper)   
        {
            _dbContext = dBContext;
            _mapper = mapper;
        }
        // handler function for create actor
        public void Handle()
        {
            var actor = _dbContext.Actors.SingleOrDefault(x => x.Name == Model.Name);
            
            // checking new actor already exists
            if (actor is not null)
            {

                // if actor exists, then it is invalid operation 
                throw new InvalidOperationException("Actor exists!");
            }

            actor = _mapper.Map<Actor>(Model);

            // add desired actor to the dbcontext
            _dbContext.Actors.Add(actor);
            // save changes to the db
            _dbContext.SaveChanges();

        }
    }
    // define actor view model
    public class CreateActorVM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }    
    }

}
