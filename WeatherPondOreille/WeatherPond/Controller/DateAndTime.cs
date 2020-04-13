﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherPond.Controller
{
    public class DateAndTime
    {
        public DateAndTime()
        {

        }

        /// <summary>
        /// Convert the date entered by the user into readable data to find weather
        /// </summary>
        /// <returns>Returns a formatted data for weather</returns>
        public string ConvertDateForWeather(string date)
        {
            string[] dateSplit = date.Split('/');

            try
            {
                // convert to integer
                int day = int.Parse(dateSplit[0]);
                int month = int.Parse(dateSplit[1]);
                int year = int.Parse(dateSplit[2]);

                string dayResult = (day < 10) ? $"0{day}" : $"{day}";
                string monthResult = (month < 10) ? $"0{month}" : $"{month}";

                return $"{year}_{monthResult}_{dayResult}";
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Vous n'avez pas respecter le format (dd/mm/yyyy)");
            }
            catch (FormatException)
            {
                Console.WriteLine("Vous n'avez pas rentré des numéros.\nVeuillez respecter le format suivant (dd/mm/yyyy)");
            }

            return null;
        }

        public string ConvertTimeForWeather(string time)
        {
            string[] timeSplit = time.Split(':');

            try
            {
                // convert to integer
                int hours = int.Parse(timeSplit[0]);
                int minutes = int.Parse(timeSplit[1]);
                int seconds = int.Parse(timeSplit[2]);

                string hoursResult = (hours < 10) ? $"0{hours}" : $"{hours}";
                string minutesResult = (minutes < 10) ? $"0{minutes}" : $"{minutes}";
                string secondsResult = (seconds < 10) ? $"0{seconds}" : $"{seconds}";

                return $"{hoursResult}:{minutesResult}:{secondsResult}";
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Vous n'avez pas respecter le format (hh:mm:ss)");
            }
            catch (FormatException)
            {
                Console.WriteLine("Vous n'avez pas rentré des numéros.\nVeuillez respecter le format suivant (dd/mm/yyyy)");
            }

            return "";
        }
    }
}