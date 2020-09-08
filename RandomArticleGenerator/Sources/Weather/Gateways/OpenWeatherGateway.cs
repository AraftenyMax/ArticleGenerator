using RandomArticleGenerator.Domain.Weather;
using System;
using System.Threading.Tasks;

namespace RandomArticleGenerator.Gateways.Weather
{
    public class OpenWeatherGateway : IWeatherGateway
    {

        public async Task<WeatherEntity> GetWeather(string city)
        {
            throw new NotImplementedException();
        }

        public async Task<WeatherEntity> GetWeatherForRandomCity()
        {
            throw new NotImplementedException();
        }
    }
}
