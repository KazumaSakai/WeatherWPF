using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWPF
{
    public class Country
    {
        public static readonly Country Japan = new Country("日本");

        public string name;

        public Country(string name)
        {
            this.name = name;
        }
    }
}
