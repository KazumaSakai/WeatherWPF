using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWPF
{
    public enum WeatherType
    {
        Null = 0,

        //  Groupe 2xx Thunderstorm
        Thunderstorm_LightRain = 200,
        Thunderstorm_Rain = 201,
        Thunderstorm_HevyRain = 202,
        LightThunderstorm = 210,
        Thunderstorm = 211,
        HeavyThunderstorm = 212,
        RaggedThunderstorm = 221,
        Thunderstorm_LightDrizzle = 230,
        Thunderstorm_Drizzle = 231,
        Thunderstorm_HeavyDrizzle = 232,

        //  Group 3xx Drizzle
        LightIntensityDrizzle = 300,
        Drizzle = 301,
        HeavyIntensityDrizzle = 302,
        LightIntensityDrizzleRain = 303,
        DrizzleRain = 311,
        HeavyIntensityDrizzleRain = 312,
        ShowerRain_Drizzle = 313,
        HeavyShowerRain_Drizzle = 314,
        Shower_Drizzle = 321,
        
        //  Group 5xx Rain
        LightRain = 500,
        ModerateRain = 501,
        HeavyIntensityRain = 502,
        VeryHeavyRain = 503,
        ExtremeRain = 504,
        FreezingRain = 511,
        LightIntensityShowerRain = 520,
        ShowerRain = 521,
        HeavyIntensityShowerRain = 522,
        RaggedShowerRain = 531,

        //  Group 6xx Snow
        LightSnow = 600,
        Snow = 601,
        HeavySnow = 602,
        Sleet = 611,
        ShowerSleet = 612,
        LightRain_Snow = 615,
        Rain_Snow = 616,
        LightShowerSnow  = 620,
        ShowerSnow = 621,
        HeavyShowerSnow = 622,

        //  Group 7xx Atmosphere
        Mist = 701,
        Smoke = 711,
        Haze = 721,
        Sand_DustWhirls = 731,
        Fog = 741,
        Sand = 751,
        Dust = 761,
        VolcanicAsh = 762,
        Squalls = 771,
        Tornado = 781,

        //  Group 8xx Clear
        ClearSky = 800,

        //  Group 80x Clouds
        FewClouds = 801,
        ScatteredClouds = 802,
        BrokenClouds = 803,
        OvercastClouds = 804,
    }
}
