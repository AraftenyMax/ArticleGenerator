using RandomArticleGenerator.Domain.Weather;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RandomArticleGenerator.Gateways.Weather
{
    public interface IWeatherGateway
    {
        Task<WeatherEntity> GetWeather(string city);
        Task<WeatherEntity> GetWeatherForRandomCity();
    }
}
