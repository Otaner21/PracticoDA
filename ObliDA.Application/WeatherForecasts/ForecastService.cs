using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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

           /* if (!_context.WeatherForecasts.Any())
            {
                forecasts.AddRange(ForecastFactory.NewWeek());
                _context.WeatherForecasts.AddRange(forecasts);
                _context.SaveChanges();
            }
            else
            {
                forecasts.AddRange(_context.WeatherForecasts);
            }*/
           forecasts.AddRange(_context.WeatherForecasts);
            return forecasts.Select(Mapper.ToDto);
        }

        public WeatherForecastOutPutDto Get(int id)
        {
            return Mapper.ToDto(_context.WeatherForecasts.FirstOrDefault(w => w.Id == id));
        }
        
        public void Create (WeatherForecastsInputDto forecast)
        {
            _context.Add(Mapper.ToModel(forecast));
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Remove(_context.WeatherForecasts.FirstOrDefault(w => w.Id == id));
            _context.SaveChanges();
        }
    }
}