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
            Console.WriteLine("--- Alert: the bug with the hours for the year 2013 are not fixed yet");
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
            List<WeatherItem> weatherItems = ProcessUserDateAndTime(startDateAndTime, endDateAndTime);

            this.PointsToGraphic(weatherItems);
            // rd.DisplayItems(weatherItems);
        }

        public int ComputeGap(int startYear, int endYear)
        {
            return endYear - startYear;
        }

        /// <summary>
        /// Algorithm to return the full list of items to the user
        /// </summary>
        /// <param name="startDateAndTime">User entry</param>
        /// <param name="userDateAndTime">User entru</param>
        public List<WeatherItem> ProcessUserDateAndTime(string startDateAndTime, string endDateAndTime)
        {
            ReadTextFiles rd = new ReadTextFiles();
            List<WeatherItem> weatherItems = new List<WeatherItem>();

            try
            {
                int startYear = int.Parse(startDateAndTime.Split('_')[0]);
                int endYear = int.Parse(endDateAndTime.Split('_')[0]);

                int currentYear = startYear;
                int gap = ComputeGap(startYear, endYear);

                if (gap == 0)
                {
                    weatherItems.AddRange(rd.ReadYear(startDateAndTime, endDateAndTime));
                    return weatherItems;
                } 
                else if (gap == 1)
                {
                    weatherItems.AddRange(rd.ReadYearStart(startDateAndTime));
                    weatherItems.AddRange(rd.ReadYearEnd(endDateAndTime));
                    return weatherItems;

                } else if (gap > 1)
                {
                    weatherItems.AddRange(rd.ReadYearStart(startDateAndTime));
                    
                    currentYear++;
                    gap -= 1;

                    while (gap > 1)
                    {
                        weatherItems.AddRange(rd.ReadFullYear(currentYear));
                        
                        currentYear++;
                        gap -= 1;
                    }
                    weatherItems.AddRange(rd.ReadYearEnd(endDateAndTime));
                    return weatherItems;
                }
                else
                {
                    return null;
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return null;
        }
        
        /// <summary>
        /// Points to display in a graphic with livechard
        /// </summary>
        /// <param name="weatherItems">Take the list in parameters</param>
        public void PointsToGraphic(List<WeatherItem> weatherItems)
        {
            int currentPoint = 0;

            int pointsToDisplay = 20;
            int totalPoints = weatherItems.Count;

            Console.WriteLine(weatherItems.Count);
            for (int i = 0; i < pointsToDisplay; i++)
            {
                currentPoint += totalPoints / 20;
                // Console.WriteLine("i: " + currentPoint + ", content: " + weatherItems[currentPoint]);
                Console.WriteLine(weatherItems[currentPoint]);
                // Ajouter les items à la courbe
            }
        }
    }
}
