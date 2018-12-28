using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherWPF
{
    public struct WindData
    {
        public float speed;
        public float direction;

        public WindData(float speed, float direction)
        {
            this.speed = speed;
            this.direction = direction;
        }
    }
}
