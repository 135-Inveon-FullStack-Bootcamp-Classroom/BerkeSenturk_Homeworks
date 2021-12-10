using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApi.DBOperations;
using WebApi.Common;
using System.Collections.Generic;

namespace WebApi.GenreOperations.GetGenres
{
    public class GetGenresQuery
    {
        private readonly ApplicationDbContext _dbContext;

        public GetGenresQuery(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<GenresViewModel> Handle()
        {
            var GenreList = _dbContext.Genres.OrderBy(x => x.Id).ToList<Genre>();
            List<GenresViewModel> vm = new List<GenresViewModel>();
            
            foreach (var Genre in GenreList)
            {
                vm.Add(new GenresViewModel(){
                    Title = Genre.Title,
                    Books = Genre.Books,
                });
            }
            
            return vm;
        }
    }

    public class GenresViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public ICollection<Book> Books { get; set; }
    }

}