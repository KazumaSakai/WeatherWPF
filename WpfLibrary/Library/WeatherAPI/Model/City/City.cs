using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWPF
{
    public class City
    {
        public static readonly City Tokyo = new City(Country.Japan, 1850144, "東京都", 35.6895f, 139.6917f);

        public Country country;

        public int id;
        public string name;
        public float latitude;
        public float longitude;

        public string imagePath
        {
            get
            {
                return "/Library/WeatherAPI/Images/CityImages/Tokyo.png";
            }
        }

        public City(Country country, int id, string name, float latitude, float longitude)
        {
            this.country = country;

            this.id = id;
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        private static readonly Dictionary<int, City> CityFromID = new Dictionary<int, City>()
        {
            {1850144, Tokyo }
        };
        public static City GetCityFromID(int ID)
        {
            return CityFromID[ID];
        }
        public static City GetCityFromEnum(CityEnum cityEnum)
        {
            return GetCityFromID((int)cityEnum);
        }
    }
}
