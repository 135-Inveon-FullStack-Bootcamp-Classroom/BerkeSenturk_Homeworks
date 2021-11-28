using AutoMapper;
using static WebApi.BookOperations.CreateBook.CreateBookCommand;
using WebApi.BookOperations.GetBookDetail;
using WebApi.BookOperations.GetBooks;

namespace WebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {   
            // CreateMap<source, target> 
            // enables the mapping of createbookmodel object to the book object
            CreateMap<CreateBookModel, Book>();

            CreateMap<Book, BookDetailViewModel>()
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => ((GenreEnum)src.GenreId).ToString()));
        
            CreateMap<Book, BooksViewModel>()
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => ((GenreEnum)src.GenreId).ToString()));
        }
    }
    
}