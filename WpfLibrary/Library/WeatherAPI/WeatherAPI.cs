using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace WeatherWPF
{
    public static class WeatherAPI
    {
        private static readonly string BaseURL = "http://api.openweathermap.org/data/2.5/forecast?";
        private static readonly string APIkey = "d24bfbaf65cc32d5ed0041481cece05e";

        public static string CreateURL(int cityID)
        {
            StringBuilder url = new StringBuilder();
            url.Append(BaseURL);
            url.AppendFormat("id={0}", cityID);
            url.AppendFormat("&APPID={0}", APIkey);
            return url.ToString();
        }

        public static async Task<WeatherData> GetWeatherData(int cityID)
        {
            string url = CreateURL(cityID);

            WeatherData resultData = null;
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    resultData = JsonConvert.DeserializeObject<WeatherData>(data);
                }
            }

            return resultData;
        }
    }
}