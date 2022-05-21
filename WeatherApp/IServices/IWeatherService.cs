using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.IServices
{
    public interface IWeatherService
    {
        Task<Weather> GetCurrent(string city);
        Task<List<Weather>> GetAll(string city);
        Task<Weather> Add();
    }
}
