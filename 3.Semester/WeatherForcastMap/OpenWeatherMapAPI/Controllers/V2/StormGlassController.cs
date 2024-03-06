using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StormGlass.Models;
using System.Data.SqlTypes;
using System.Net.Http.Headers;

namespace OpenWeatherMapAPI.Controllers.V2
{

    [ApiController]
    [Route("[controller]")]
    [ApiVersion("2.0")]
    public class StormGlassController : ControllerBase
    {
        private readonly ILogger<StormGlassController> _logger;

        public StormGlassController(ILogger<StormGlassController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<RootV2> Get()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.stormglass.io/v2/weather/point?lat=55.39&lng=10.38&params=swellHeight,swellPeriod");

                string apiKey = "a96ad44a-629d-11ee-a26f-0242ac130002-a96ad4a4-629d-11ee-a26f-0242ac130002";

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(apiKey);


                var response = await client.GetFromJsonAsync<RootV2>(client.BaseAddress);


                return response;
            }

        }
    }
}
