using RandomArticleGenerator.Domain.Weather;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Gateways.Weather
{
    public interface IWeatherGateway
    {
        WeatherEntity GetWeather(string city);
        WeatherEntity GetWeatherForRandomCity();
    }
}
