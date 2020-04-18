using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherPond.Model;

namespace WeatherPond.Controller
{
    public class Menu
    {
        public void Launch()
        {
            // user date
            Console.WriteLine("Enter a starting date (as mm/dd/yyyy): ");
            string dateStart = Console.ReadLine();
            // user time
            Console.WriteLine("Enter a starting hour between 0 and 23: ");
            string timeStart = Console.ReadLine();

            DateAndTime dt = new DateAndTime();
            string startDateAndTime = dt.ReadUserDateAndTime(dateStart, timeStart);

            // user date
            Console.WriteLine("Enter an ending date (as mm/dd/yyyy): ");
            string dateEnd = Console.ReadLine();
            // user time
            Console.WriteLine("Enter an ending hour between 0 and 23: ");
            string timeEnd = Console.ReadLine();

            string endDateAndTime = dt.ReadUserDateAndTime(dateEnd, timeEnd);

            ReadTextFiles rd = new ReadTextFiles();

            List<WeatherItem> resultWeatherItems = rd.ReadYear(startDateAndTime, endDateAndTime);

            rd.DisplayItems(resultWeatherItems);

            Console.ReadLine();
        }

        public int ComputeGap(int startYear, int endYear)
        {
            return endYear - startYear;
        }
    }
}
