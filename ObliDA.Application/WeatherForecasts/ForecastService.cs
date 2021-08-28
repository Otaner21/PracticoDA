using System.Collections.Generic;
using System.Linq;
using ObliDA.Application.WeatherForecasts.Dtos;
using ObliDA.Domain;
using ObliDA.EntityFrameworkCore;

namespace ObliDA.Application.WeatherForecasts
{
    public class ForecastService
    {
        private readonly Context _context;

        public ForecastService(Context context)
        {
            _context = context;
        }

        public IEnumerable<WeatherForecastOutPutDto> GetAll()
        {
            var forecasts = new List<WeatherForecast>();

            if (!_context.WeatherForecasts.Any())
            {
                forecasts.AddRange(ForecastFactory.NewWeek());
                _context.WeatherForecasts.AddRange(forecasts);
                _context.SaveChanges();
            }
            else
            {
                forecasts.AddRange(_context.WeatherForecasts);
            }

            return forecasts.Select(Mapper.ToDto);
        }
    }
}