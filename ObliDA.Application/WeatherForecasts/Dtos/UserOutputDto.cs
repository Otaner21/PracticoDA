using System.Collections.Generic;
using ObliDA.Domain;

namespace ObliDA.Application.WeatherForecasts.Dtos
{
    public class UserOutputDto
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public virtual ICollection<WeatherForecast> Forecasts { get; set; }
    }
}