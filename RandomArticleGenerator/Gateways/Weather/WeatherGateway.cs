using RandomArticleGenerator.Domain.Weather;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Gateways.Weather
{
    public interface WeatherGateway
    {
        WeatherEntity GetWeather(string city);
    }
}
