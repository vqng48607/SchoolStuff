using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Models;

namespace OpenWeatherMapAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<Root> Get()
        {
            HttpClient client = new HttpClient();
            string URL = "http://api.openweathermap.org/data/2.5/forecast?lat=55.403756&lon=10.402370&appid=6c27b2863f83391902b903b932e7f674&units=metric";

            var weatherForecast = await client.GetFromJsonAsync<Root>(URL);
            return weatherForecast;
        }


    }
}