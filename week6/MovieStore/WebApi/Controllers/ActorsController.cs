using AutoMapper;
// using WebApi.App.ActorOperations.Commands;
using WebApi.App.ActorOperations.Queries;
using WebApi.DBOperations;
using WebApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActorsController : ControllerBase
    {
        private readonly MovieStoreDBContext _dbContext;
        private readonly IMapper _mapper;

        public ActorsController(MovieStoreDBContext dBContext, IMapper mapper)
        {
            _dbContext = dBContext;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetActors()
        {
            GetActorsQuery query = new(_dbContext, _mapper);
            var actors = query.Handle();

            return Ok(actors);

        }
    }
}