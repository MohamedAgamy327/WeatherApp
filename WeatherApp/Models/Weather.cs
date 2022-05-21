using System;

namespace WeatherApp.Models
{
    public class Weather
    {
        public string Icon { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }
        public decimal Windspeed { get; set; }
        public DateTime Date { get; set; }
    }
}
