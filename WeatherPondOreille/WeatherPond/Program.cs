using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherPond.Controller;

namespace WeatherPond
{
    class Program
    {
        static void Main(string[] args)
        {
            // user entries
            Console.WriteLine("Enter a date date (as mm/dd/yyyy): ");
            string date = Console.ReadLine();

            // process date
            DateAndTime manageDateTime = new DateAndTime();
            date = manageDateTime.ConvertDateForWeather(date);

            Console.WriteLine(date);

            ReadTextFiles rd = new ReadTextFiles();

            rd.ReadWeatherData("2012_01_01 00:02:14", "2012_01_01 00:33:31");
            Console.ReadLine();
        }
    }
}
