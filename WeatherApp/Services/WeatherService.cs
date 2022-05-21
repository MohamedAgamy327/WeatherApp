using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.IServices;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService : IWeatherService
    {
        List<Weather> weathers = new List<Weather>
        {
            new Weather
            {
                Country="UK",
                City="London",
                Date=DateTime.Now.AddHours(-3),
                Description="Cloudy",
                Temperature=20,
                Humidity=45,
                Windspeed=20
            },
                new Weather
            {
                Country="UK",
                City="London",
                Date=DateTime.Now,
                Description="Cloudy2",
                Temperature=20,
                Humidity=45,
                Windspeed=20
            },
                new Weather
            {
                 Country = "FR",
                City = "Paris",
                Date=DateTime.Now.AddHours(-2),
                Description="Cloudy",
                Temperature=20,
                Humidity=45,
                Windspeed=20
            },
                  new Weather
            {
                 Country = "FR",
                City = "Paris",
                Date=DateTime.Now,
                Description="Cloudy2",
                Temperature=20,
                Humidity=45,
                Windspeed=20
            }
            ,
             new Weather
            {
               Country = "AUT",
                City = "Vienna",
                Date=DateTime.Now.AddHours(-2),
                Description="Cloudy",
                Temperature=20,
                Humidity=45,
                Windspeed=20
            },
                new Weather
            {
               Country = "AUT",
                City = "Vienna",
                Date=DateTime.Now,
                Description="Cloudy",
                Temperature=20,
                Humidity=45,
                Windspeed=20
            }
        };

        public Task<Weather> Add()
        {
            throw new NotImplementedException();
        }
        public Task<List<Weather>> GetAll(string city)
        {
            return Task.FromResult(weathers.Where(d => d.City == city).ToList());
        }
        public Task<Weather> GetCurrent(string city)
        {
            return Task.FromResult(weathers.OrderByDescending(d => d.Date).FirstOrDefault(d => d.City == city));
        }
    }
}
