using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWPF
{
    public static class WeatherDictionary
    {
        public static readonly Dictionary<WeatherType, string> WeatherNames = new Dictionary<WeatherType, string>()
        {
            { WeatherType.Thunderstorm_LightRain, "雷雨" },
            { WeatherType.Thunderstorm_Rain, "雷雨" },
            { WeatherType.Thunderstorm_HevyRain, "雷雨" },
            { WeatherType.LightThunderstorm, "雷雨" },
            { WeatherType.Thunderstorm, "雷雨" },
            { WeatherType.HeavyThunderstorm, "雷雨" },
            { WeatherType.RaggedThunderstorm, "雷雨" },
            { WeatherType.Thunderstorm_LightDrizzle, "雷雨" },
            { WeatherType.Thunderstorm_Drizzle, "雷雨" },
            { WeatherType.Thunderstorm_HeavyDrizzle, "雷雨" },

            { WeatherType.LightIntensityDrizzle, "霧雨" },
            { WeatherType.Drizzle, "霧雨" },
            { WeatherType.HeavyIntensityDrizzle, "霧雨" },
            { WeatherType.LightIntensityDrizzleRain, "霧雨" },
            { WeatherType.DrizzleRain, "霧雨" },
            { WeatherType.HeavyIntensityDrizzleRain, "霧雨" },
            { WeatherType.ShowerRain_Drizzle, "霧雨" },
            { WeatherType.HeavyShowerRain_Drizzle, "霧雨" },
            { WeatherType.Shower_Drizzle, "霧雨" },

            { WeatherType.LightRain, "雨" },
            { WeatherType.ModerateRain, "雨" },
            { WeatherType.HeavyIntensityRain, "雨" },
            { WeatherType.VeryHeavyRain, "雨" },
            { WeatherType.ExtremeRain, "雨" },
            { WeatherType.FreezingRain, "雨" },
            { WeatherType.LightIntensityShowerRain, "雨" },
            { WeatherType.ShowerRain, "雨" },
            { WeatherType.HeavyIntensityShowerRain, "雨" },
            { WeatherType.RaggedShowerRain, "雨" },

            { WeatherType.LightSnow, "雪" },
            { WeatherType.Snow, "雪" },
            { WeatherType.HeavySnow, "雪" },
            { WeatherType.Sleet, "雪" },
            { WeatherType.ShowerSleet, "雪" },
            { WeatherType.LightRain_Snow, "雪" },
            { WeatherType.Rain_Snow, "雪" },
            { WeatherType.LightShowerSnow, "雪" },
            { WeatherType.ShowerSnow, "雪" },
            { WeatherType.HeavyShowerSnow, "雪" },

            { WeatherType.Mist, "霧" },
            { WeatherType.Smoke, "霧" },
            { WeatherType.Haze, "霞" },
            { WeatherType.Sand_DustWhirls, "砂埃" },
            { WeatherType.Fog, "霧" },
            { WeatherType.Sand, "砂埃" },
            { WeatherType.VolcanicAsh, "火山灰" },
            { WeatherType.Squalls, "スコール" },
            { WeatherType.Tornado, "竜巻" },

            { WeatherType.ClearSky, "快晴" },
            { WeatherType.FewClouds, "晴れ" },
            { WeatherType.ScatteredClouds, "晴れ" },
            { WeatherType.BrokenClouds, "晴れ" },
            { WeatherType.OvercastClouds, "曇り" },
        };
    }
}
