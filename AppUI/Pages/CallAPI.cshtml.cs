using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace AppUI.Pages
{
    [BindProperties]
    public class CallAPIModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public CallAPIModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        
        public class WeatherForecastReturned
        {
            [JsonPropertyName("date")]
            public DateTime date { get; set; }

            //[JsonPropertyName("temperatureC")]
            public int temperatureC { get; set; }

            [JsonPropertyName("temperatureF")]
            public int temperatureF { get; set; }

            [JsonPropertyName("summary")]
            public string summary { get; set; }

            public WeatherForecastReturned() {}

        }

        public string TestData { get; set; }
        public List<WeatherForecastReturned> WFRList = new List<WeatherForecastReturned>();

        public class WeatherForecastReturnedCollection
        {
            private List<WeatherForecastReturned> weatherforcastsreturned;

            [JsonPropertyName("weatherdata")]
            public List<WeatherForecastReturned> Weatherforcastsreturned { get => weatherforcastsreturned; set => weatherforcastsreturned = value;}

        }

        public async Task OnGet()
        {             
            TestData = "Test Data to display on screen";

            TestData = await GetAPIData();                                    

            WFRList =  JsonSerializer.Deserialize<List<WeatherForecastReturned>>(TestData);

        }
        static async Task<string> GetAPIData()
        {
            // async Task<WeatherSummariesModel> 
            HttpClient APIclient = new HttpClient();

            APIclient.DefaultRequestHeaders.Accept.Clear();
            APIclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string url = "https://localhost:5001/WeatherForecast";                        
            // url = "http://localhost:5000/WeatherForecast";                        
            
            HttpResponseMessage response =  await APIclient.GetAsync(url);

            var WeatherData = await response.Content.ReadAsStringAsync();

            //var WeatherData = "{\"weatherdata\":[{\"Date\":\"2019-08-01T00:00:00-07:00\", \"TemperatureCelsius\": 25, \"TemperatureF\": 85, \"Summary\": \"Hot\"}]}";
           //WeatherData = "[{\"date\":\"2019-08-01T00:00:00-07:00\", \"temperatureC\": 25, \"temperatureF\": 85, \"summary\": \"Hot\"},{\"date\":\"2014-08-01T00:00:00-02:00\", \"temperatureC\": 15, \"temperatureF\": 55, \"summary\": \"Cold\"}]";
           //var WeatherData = "{\"weatherdata\":[{\"date\":\"2019-08-01T00:00:00-07:00\", \"temperatureC\": 25, \"temperatureF\": 85, \"summary\": \"Hot\"},{\"date\":\"2014-08-01T00:00:00-02:00\", \"temperatureC\": 15, \"temperatureF\": 55, \"summary\": \"Cold\"}]}";
            
            //WeatherForecastReturned WFR = JsonSerializer.Deserialize<WeatherForecastReturned>(WeatherData);            
            
           //WeatherForecastReturnedCollection WFRCollection = JsonSerializer.Deserialize<WeatherForecastReturnedCollection>(WeatherData);

            //WFRList = JsonSerializer.Deserialize<List<WeatherForecastReturned>>(WeatherData);
            

	        //line just to have for breakpoint after call
            url = "https://localhost:5001/WeatherForecast";

            return WeatherData;

        }



    }
}