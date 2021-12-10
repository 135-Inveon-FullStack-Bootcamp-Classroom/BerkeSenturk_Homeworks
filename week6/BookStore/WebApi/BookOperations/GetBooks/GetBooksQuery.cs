using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApi.DBOperations;
using WebApi.Common;


namespace WebApi.BookOperations.GetBooks
{
    public class GetBooksQuery
    {
        private readonly ApplicationDbContext _dbContext;

        public GetBooksQuery(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<BooksViewModel> Handle()
        {

            var bookList = _dbContext.Books.OrderBy(x => x.Id).ToList<Book>();
            var genreList = _dbContext.Genres.ToList<Genre>();

            List<BooksViewModel> vm = new List<BooksViewModel>();
            List<GenresViewModel> genresVm = new List<GenresViewModel>();

            foreach(var genre in genreList)
            {
                genresVm.Add(new GenresViewModel()
                {
                    Id = genre.Id,
                    Title = genre.Title
                });
            }
            foreach (var book in bookList)
            {
                vm.Add(new BooksViewModel(){
                    Title = book.Title,
                    // Genre = _dbContext.Genres.Where(g => g.Id == book.GenreId).FirstOrDefault().Title,
                    genreVm = genresVm.Where(g => g.Id == book.GenreId).FirstOrDefault(),
                    PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy"),
                    PageCount = book.PageCount
                });
            }
            
            return vm;
        }
    }

    public class BooksViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public GenresViewModel genreVm { get; set; }
    }
    public class GenresViewModel

    {
        public int Id { get; set; }
        public string Title { get; set; }
        
    }

}