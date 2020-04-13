using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherPond.Model
{
    /// <summary>
    /// Used to store data from a specific line 
    /// </summary>
    public class WeatherItem
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public double BarometricPress { get; set; }

        public override string ToString()
        {
            return $"WeatherItem[Date: {Date}; Time: {Time}; BarometricPress: {BarometricPress}]";
        }
    }
}
