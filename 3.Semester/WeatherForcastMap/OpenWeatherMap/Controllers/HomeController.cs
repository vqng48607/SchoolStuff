using Microsoft.AspNetCore.Mvc;
using OpenWeatherMap.Models;
using System.Diagnostics;
using WeatherForecast.Models;
using StormGlass.Models;

namespace OpenWeatherMap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            HttpClient client = new HttpClient();
            string URL = "https://localhost:7191/StormGlass?api-version=1";

            var weatherForecast = await client.GetFromJsonAsync<RootV2>(URL);
            

            return View(weatherForecast);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private static HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("http://api.openweathermap.org")
        };

        
    }
}