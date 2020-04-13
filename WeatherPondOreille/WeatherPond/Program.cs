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
            // user date
            Console.WriteLine("Enter a starting date (as mm/dd/yyyy): ");
            string dateStart = Console.ReadLine();
            // user time
            Console.WriteLine("Enter a starting time (as hh:mm:ss): ");
            string timeStart = Console.ReadLine();

            DateAndTime dt = new DateAndTime();
            string startDateAndTime = dt.ReadUserDateAndTime(dateStart, timeStart);

            // user date
            Console.WriteLine("Enter an ending date (as mm/dd/yyyy): ");
            string dateEnd = Console.ReadLine();
            // user time
            Console.WriteLine("Enter an ending time (as hh:mm:ss): ");
            string timeEnd = Console.ReadLine();

            string endDateAndTime = dt.ReadUserDateAndTime(dateEnd, timeEnd);

            ReadTextFiles rd = new ReadTextFiles();

            rd.ReadWeatherData(startDateAndTime, endDateAndTime);
            Console.ReadLine();
        }
    }
}
