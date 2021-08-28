using System.Collections.Generic;
namespace ObliDA.Domain
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public virtual ICollection<WeatherForecast> Forecasts { get; set; }
    }
}