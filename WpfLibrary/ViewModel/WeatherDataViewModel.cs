using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Drawing;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WeatherWPF.Properties;

namespace WeatherWPF
{
    public class WeatherDataViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string CityName { get; set; }
        public string CityImage { get; set; }
        public string WeatherIcon { get; set; }
        public string WeatherName { get; set; }
        public string Rain { get; set; }
        public string Humidity { get; set; }
        public string WindSpeed { get; set; }

        public WeatherDataViewModel()
        {
            this.CityName = "東京";
            this.CityImage = "/Resources/Images/CityImages/Tokyo.png";
            this.WeatherIcon = "/Resources/Images/WeatherIcons/Sun.png";
            this.WeatherName = "晴れ";
            this.Rain = "降水確率 : 10%";
            this.Humidity = "湿度 : 10%";
            this.WindSpeed = "風速 : 4m/s";
        }

    }
}
