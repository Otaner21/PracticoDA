using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ObliDA.Application.WeatherForecasts;
using ObliDA.Application.WeatherForecasts.Dtos;
using ObliDA.EntityFrameworkCore;

namespace obliDA.HttpApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly Context _context;
        private readonly UserService _userService;


        public UserController(Context context)
        {
            _context = context;
            _userService = new UserService(context);
        }

        [HttpGet]
        public IEnumerable<UserOutputDto> Get()
        {
            return _userService.GetAll();
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserInputDto user)
        {
            _userService.Create(user);
            return Ok();
        }
    }
}