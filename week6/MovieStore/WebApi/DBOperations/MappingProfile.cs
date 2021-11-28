using AutoMapper;
using WebApi.App.ActorOperations.Commands;
using WebApi.App.ActorOperations.Queries;

using WebApi.App.MovieOperations.Queries;
using WebApi.App.MovieOperations.Commands;

using WebApi.App.DirectorOperations.Commands;
using WebApi.App.DirectorOperations.Queries;

using WebApi.App.GenreOperations.Commands;
using WebApi.App.GenreOperations.Queries;

using WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.DBOperations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // create map for Movie  & Cast entity within wiew model and dto
            CreateMap<Cast, CastMoviesDTO>()
                .ForMember(dto => dto.Name, opt => opt.MapFrom(x => x.Actor.Name))
                .ForMember(dto => dto.Surname, opt => opt.MapFrom(x => x.Actor.Surname));
            
            CreateMap<Movie, MoviesVM>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.GenreName))
                .ForMember(dest => dest.Director, opt => opt.MapFrom(src => src.Director.Name))
                .ForMember(dest => dest.Director, opt => opt.MapFrom(src => src.Director.Surname));

            CreateMap<CreateMovieVM, Movie>();

            // GENRE
            CreateMap<Movie, CastMoviesDTO>();
            CreateMap<Genre, GenresVM>();

            CreateMap<CreateGenreVM, Genre>();

            // DIRECTOR
            CreateMap<Director, DirectorsVM>();
            CreateMap<CreateDirectorVM, Director>();

            // ACTOR
            CreateMap<Cast, CastMoviesDTO>()
                .ForMember(dto => dto.Name, opt => opt.MapFrom(x => x.Movie.MovieName));
            CreateMap<Actor, ActorsVM>();
            CreateMap<CreateActorVM, Actor>();
        }
    }
}