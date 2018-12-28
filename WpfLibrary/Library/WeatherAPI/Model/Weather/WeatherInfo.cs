using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWPF
{
    public struct WeatherInfo
    {
        public WeatherType WeatherType;
        public string WeatherName
        {
            get
            {
                return WeatherDictionary.WeatherNames[this.WeatherType];
            }
        }

        public float Temperature;
        public float TemperatureMax;
        public float TemperatureMin;
        public float Pressure;
        public float Pressure_Sea;
        public float Pressure_Ground;
        public float Humidity;

        public int Clouds;
        public WindData WindData;

        public DateTime Time;

        public WeatherInfo(WeatherGetData.List getData)
        {
            this.WeatherType = (WeatherType) getData?.weather[0].id;

            this.Temperature = getData?.main?.temp ?? 0.0f;
            this.TemperatureMax = getData?.main?.temp_max ?? 0.0f;
            this.TemperatureMin = getData?.main?.temp_min ?? 0.0f;
            this.Pressure = getData?.main?.pressure ?? 0.0f;
            this.Pressure_Sea = getData?.main?.sea_level ?? 0.0f;
            this.Pressure_Ground = getData?.main?.grnd_level ?? 0.0f;
            this.Humidity = getData?.main?.humidity ?? 0.0f;

            this.Clouds = getData?.clouds?.all ?? 0;
            this.WindData = new WindData(getData.wind.speed, getData.wind.deg);

            this.Time = DateTime.Parse((getData?.dt_txt ?? "").Replace('-', '/'));
        }
    }
}
