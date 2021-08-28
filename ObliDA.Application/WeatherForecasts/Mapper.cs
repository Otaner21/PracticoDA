using ObliDA.Domain;
using ObliDA.Application.WeatherForecasts.Dtos;

namespace ObliDA.Application.WeatherForecasts
{
    public class Mapper
    {
        public static WeatherForecastOutPutDto ToDto(WeatherForecast forecast)
        {
            return new WeatherForecastOutPutDto
            {
                Id = forecast.Id,
                Date = forecast.Date,
                Summary = forecast.Summary,
                TemperatureC = forecast.TemperatureC,
                //TemperatureF = forecast.TemperatureF,
                //UserId = forecast.UserId
            };
        }
    }
}