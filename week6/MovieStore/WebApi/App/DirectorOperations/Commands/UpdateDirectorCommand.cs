using WebApi.DBOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.DirectorOperations.Commands
{
    public class UpdateDirectorCommand
    {
        private readonly MovieStoreDBContext _dbContext;
        public int DirectorId { get; set; }
        public UpdateDirectorVM Model { get; set; }

        public UpdateDirectorCommand(MovieStoreDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        // handler function for update Director
        public void Handle()
        {
            var director = _dbContext.Directors.SingleOrDefault(x => x.DirectorId == DirectorId);

            if (director is null)
            {
                // if Director is not exist, then it is a invalid operation
                throw new InvalidOperationException("Director not found!");
            }

            // update props
            director.Name = Model.Name;
            director.Surname = Model.Surname;
            director.Age = Model.Age;

            _dbContext.SaveChanges();
        }
    }

    public class UpdateDirectorVM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
