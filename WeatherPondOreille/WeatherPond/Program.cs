using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherPond.Controller;
using WeatherPond.Model;

namespace WeatherPond
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Menu menu = new Menu();
            menu.Launch(); */
            ReadTextFiles rd = new ReadTextFiles();

            List<WeatherItem> resultWeatherItems = rd.ReadYearEnd("2012_08_03 15");
            // rd.DisplayItems(resultWeatherItems);
        }
    }
}
