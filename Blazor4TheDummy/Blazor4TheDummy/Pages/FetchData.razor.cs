using Blazor4TheDummy.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor4TheDummy.Pages
{
    public partial class FetchData
    {
        private WeatherForecast[] forecasts;

        [Inject]
        protected HttpClient HttpClient { get; set; }

        [Inject]
        protected ICustomService CustomService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            forecasts = await HttpClient.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }

        public class WeatherForecast
        {
            public DateTime Date { get; set; }

            public int TemperatureC { get; set; }

            public string Summary { get; set; }

            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }

    }
}
