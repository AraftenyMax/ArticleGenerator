using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RandomArticleGenerator.Domain.Weather
{
    public class WeatherEntity : IEquatable<WeatherEntity>
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Timezone { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public int Clouds { get; set; }
        public int Visibility { get; set; }
        public int WindDegree { get; set; }
        public double WindSpeed { get; set; }

        /*
         * #TODO: Group fields by entities
         */
        public bool Equals(WeatherEntity other)
        {
            bool longitudes = this.Longitude == other.Longitude;
            bool latitudes = this.Latitude == other.Latitude;
            bool timezones = this.Timezone == other.Timezone;
            bool sunrises = this.Sunrise == other.Sunrise;
            bool sunsets = this.Sunset == other.Sunset;
            bool pressures = this.Pressure == other.Pressure;
            bool humidities = this.Humidity == other.Humidity;
            bool clouds = this.Clouds == other.Clouds;
            bool visibilities = this.Visibility == other.Visibility;
            bool windDegrees = this.WindDegree == other.WindDegree;
            bool windSpeeds = this.WindSpeed == other.WindSpeed;

            return longitudes && latitudes && timezones && sunrises && sunsets 
                && pressures && humidities && clouds && visibilities 
                && windDegrees && windSpeeds;
        }
    }
}
