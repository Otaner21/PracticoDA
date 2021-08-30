using System;
using System.Collections.Generic;
using System.Linq;
using ObliDA.Application.WeatherForecasts.Dtos;
using ObliDA.Domain;
using ObliDA.EntityFrameworkCore;

namespace ObliDA.Application.WeatherForecasts
{
    public class UserService
    {
        private readonly Context _context;

        public UserService(Context context)
        {
            _context = context;
        }

        public IEnumerable<UserOutputDto> GetAll()
        {
            var Users = new List<User>();
            if (!_context.Users.Any())
            {
                User renato = new User();
                renato.Id = 0;
                renato.Username = "Renato";
                renato.Forecasts = ForecastFactory.NewWeek(renato);
                _context.Users.Add(renato);
                _context.SaveChanges();
            }

            Users.AddRange(_context.Users);
            return Users.Select(Mapper.DtoUser);
        }

        public void Create(UserInputDto user)
        {
            _context.Add(Mapper.ToModelUser(user));
            _context.SaveChanges();
        }
    }
}