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

        public WeatherData model { get; set; }

        public string CityName
        {
            get
            {
                return model.city.name;
            }
        }
        public string CityImagePath
        {
            get
            {
                return model.city.imagePath;
            }
        }
        public string WeatherIcon
        {
            get
            {
                return string.Format("/Library/WeatherAPI/Images/WeatherIcons/Sun.png");
            }
        }
        public string WeatherName
        {
            get
            {
                return model.weatherInfoList[2].WeatherName;
            }
        }
        public string Humidity
        {
            get
            {
                return string.Format("湿度 : {0}%", model.weatherInfoList[2].Humidity);
            }
        }
        public string Temperature
        {
            get
            {
                return string.Format("気温 : {0}℃", (model.weatherInfoList[2].Temperature - 273.15f).ToString("0.00"));
            }
        }
        public string Time
        {
            get
            {
                return model.weatherInfoList[2].Time.ToString("MM/dd hh:mm");
            }
        }

        public WeatherDataViewModel(WeatherData model)
        {
            this.model = model;
        }

    }
}
