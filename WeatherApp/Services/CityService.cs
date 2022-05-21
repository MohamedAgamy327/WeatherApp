using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.IServices;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class CityService : ICityService
    {
        List<City> cities = new List<City>
        {
            new City
            {
                Country="UK",
                Name="London"
            },
                new City
            {
                 Country = "FR",
                Name = "Paris"
            }
            ,
             new City
            {
               Country = "AUT",
                Name = "Vienna"
            }
        };

        public Task<City> Add()
        {
            throw new NotImplementedException();
        }
        public Task<List<City>> GetAll()
        {
            return Task.FromResult(cities);
        }
    }
}
