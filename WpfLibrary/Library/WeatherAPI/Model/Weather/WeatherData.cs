using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWPF
{
    public class WeatherData
    {
        public City city;
        public List<WeatherInfo> weatherInfoList = new List<WeatherInfo>();

        public WeatherData(WeatherGetData getData)
        {
            this.city = City.GetCityFromID(getData.city.id);

            foreach(WeatherGetData.List item in getData.list)
            {
                this.weatherInfoList.Add(new WeatherInfo(item));
            }
        }
    }
}
