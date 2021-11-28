using WebApi.DBOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.App.DirectorOperations.Commands
{
    public class DeleteDirectorCommand
    {
        private readonly MovieStoreDBContext _dbContext;
        public int DirectorId { get; set; }

        public DeleteDirectorCommand(MovieStoreDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        // handler function for delete Director
        public void Handle()
        {
            var director = _dbContext.Directors.SingleOrDefault(x => x.DirectorId == DirectorId);
            
            // if Director is not exist, then it is a invalid operation
            if (director is null)
            {
                throw new InvalidOperationException("Director not found!");
            }

            // remove Director from the dbcontext
            _dbContext.Directors.Remove(director);
        
            // finally save the changes
            _dbContext.SaveChanges();
        }
    }
}