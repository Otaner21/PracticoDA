using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ObliDA.Application.WeatherForecasts;
using ObliDA.Application.WeatherForecasts.Dtos;
using ObliDA.Domain;
using ObliDA.EntityFrameworkCore;


namespace obliDA.HttpApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        private readonly Context _context;
        private readonly ForecastService _forecastService;
        public WeatherForecastController(Context context)
        {
            _context = context;
            _forecastService = new ForecastService(context);
        }

        [HttpGet]
        public IEnumerable<WeatherForecastOutPutDto> Get()
        {
            return _forecastService.GetAll();
        }

        
    }
}
