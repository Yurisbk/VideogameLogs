using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Videogame_DB.Domain.Entities;
using Videogame_DB.Domain.Interfaces;
using Videogame_DB.Service.Services;
using Videogame_DB.Service.Validators;

namespace Videogame_DB.Controllers
{
    [Route("V1/PersonalGamesApi")]
    [ApiController]
    public class PersonalGamesController : ControllerBase
    {
        private readonly IBaseService<PersonalGames> _baseUserService;

        public PersonalGamesController(IBaseService<PersonalGames> baseUserService)
        {
            _baseUserService = baseUserService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] PersonalGames user)
        {
            if (user == null)
                return NotFound();

            return Execute(() => _baseUserService.Add<PersonalGamesValidator>(user).Id);
        }

        [HttpPut]
        public IActionResult Update([FromBody] PersonalGames user)
        {
            if (user == null)
                return NotFound();

            return Execute(() => _baseUserService.Update<PersonalGamesValidator>(user));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();

            Execute(() =>
            {
                _baseUserService.Delete(id);
                return true;
            });

            return new NoContentResult();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Execute(() => _baseUserService.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() => _baseUserService.GetById(id));
        }

        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
    
}
