using Microsoft.AspNetCore.Mvc;

namespace Attendance.API.Controllers
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

        [HttpGet(Name = "GetWeatherForecast")]


        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();   
             

        }

        [HttpGet]
        public List<string> getdrivers()
        {
            List<string> a = new List<string>();
            a.Add("driver1");
            a.Add("driver2");
            return a;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            string result = "DriverName" + id;
            return result;
        }

        [HttpPost]
        public void SaveDriver(string name)
        {
            string localVar = name;
        }
    }
}
