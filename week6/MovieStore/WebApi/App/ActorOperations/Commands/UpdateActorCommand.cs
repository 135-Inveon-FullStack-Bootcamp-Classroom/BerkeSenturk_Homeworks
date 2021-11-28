using WebApi.DBOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.ActorOperations.Commands
{
    public class UpdateActorCommand
    {
        private readonly MovieStoreDBContext _dbContext;
        public int ActorId { get; set; }
        public UpdateActorVM Model { get; set; }

        public UpdateActorCommand(MovieStoreDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        // handler function for update actor
        public void Handle()
        {
            var actor = _dbContext.Actors.SingleOrDefault(x => x.ActorId == ActorId);

            if (actor is null)
            {
                // if actor is not exist, then it is a invalid operation
                throw new InvalidOperationException("Actor not found!");
            }

            // update props
            actor.Name = Model.Name;
            actor.Surname = Model.Surname;
            actor.Age = Model.Age;

            _dbContext.SaveChanges();
        }
    }

    public class UpdateActorVM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
