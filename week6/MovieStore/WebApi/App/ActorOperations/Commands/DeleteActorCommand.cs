using WebApi.DBOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.ActorOperations.Commands
{
    public class DeleteActorCommand
    {
        private readonly MovieStoreDBContext _dbContext;
        public int ActorId { get; set; }

        public DeleteActorCommand(MovieStoreDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        // handler function for delete actor
        public void Handle()
        {
            var actor = _dbContext.Actors.SingleOrDefault(x => x.ActorId == ActorId);
            
            // if actor is not exist, then it is a invalid operation
            if (actor is null)
            {
                throw new InvalidOperationException("Actor not found!");
            }

            // remove actor from the dbcontext
            _dbContext.Actors.Remove(actor);
        
            // finally save the changes
            _dbContext.SaveChanges();
        }
    }
}