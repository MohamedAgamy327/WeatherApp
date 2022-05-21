using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.IServices
{
    public interface ICityService
    {
        Task<List<City>> GetAll();
        Task<City> Add();
    }
}
