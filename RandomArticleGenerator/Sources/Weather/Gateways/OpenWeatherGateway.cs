using RandomArticleGenerator.Domain.Weather;
using System;

namespace RandomArticleGenerator.Gateways.Weather
{
    class OpenWeatherGateway : IWeatherGateway
    {

        public WeatherEntity GetWeather(string city)
        {
            throw new NotImplementedException();
        }

        public WeatherEntity GetWeatherForRandomCity()
        {
            throw new NotImplementedException();
        }
    }
}
