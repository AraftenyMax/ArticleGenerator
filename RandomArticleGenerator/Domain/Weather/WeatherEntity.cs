using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Domain.Weather
{
    public class WeatherEntity
    {
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Timezone { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public int Clouds { get; set; }
        public int Visibility { get; set; }
        public int WindDegree { get; set; }
        public int WindSpeed { get; set; }
    }
}
