using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWPF
{
    public struct WeatherInfo
    {
        public float? Temperature;
        public float? TemperatureMax;
        public float? TemperatureMin;
        public float? Pressure;
        public float? Pressure_Sea;
        public float? Pressure_Ground;
        public float? Humidity;

        public WeatherInfo(WeatherGetData.List getData)
        {
            WeatherGetData.List.Main main = getData?.main;

            this.Temperature = main?.temp;
            this.TemperatureMax = main?.temp_max;
            this.TemperatureMin = main?.temp_min;
            this.Pressure = main?.pressure;
            this.Pressure_Sea = main?.sea_level;
            this.Pressure_Ground = main?.grnd_level;
            this.Humidity = main?.humidity;
        }
    }
}
