using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;

namespace WeatherWPF
{
    public class WeatherDataViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private WeatherData model;

        public string CityName
        {
            get
            {
                return model.city.name;
            }
        }
        public string CityImage
        {
            get
            {
                return string.Format("/Resources/Images/CityImages/Tokyo.png");
            }
        }
        public string WeatherIcon
        {
            get
            {
                return string.Format("/Resources/Images/WeatherIcons/Sun.png");
            }
        }
        public string WeatherName
        {
            get
            {
                return "晴れ";
            }
        }
        public string Rain { get; set; }
        public string Humidity
        {
            get
            {
                return string.Format("湿度 : {0}", model.weatherInfoList[0].Humidity);
            }
        }
        public string WindSpeed { get; set; }

        public WeatherDataViewModel(WeatherData model)
        {
            this.model = model;
        }

    }
}
