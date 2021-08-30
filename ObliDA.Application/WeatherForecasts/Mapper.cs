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
                UserId = forecast.UserId
            };
        }

        public static WeatherForecast ToModel(WeatherForecastsInputDto forecast)
        {
            return new WeatherForecast
            {
                //Id = forecast.Id,
                Date = forecast.Date,
                Summary = forecast.Summary,
                TemperatureC = forecast.TemperatureC,
                //UserId = forecast.UserId
            };
        }

        public static UserOutputDto DtoUser(User u)
        {
            return new UserOutputDto
            {
                Id = u.Id,
                Username = u.Username,
                Forecasts = u.Forecasts
            };
        }

        public static User ToModelUser(UserInputDto user)
        {
            return new User
            {
                Username = user.Username,
                Forecasts = user.Forecasts
            };
        }
    }
}