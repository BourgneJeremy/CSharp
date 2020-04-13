using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WeatherPond.Model;

namespace WeatherPond.Controller
{
    public class ReadTextFiles
    {
        // whitespace character used essentially for the split method
        private char[] Whitespace = new char[] { ' ', '\t' };

        public bool IsStartDateFound { get; set; }
        public bool IsEndDateFound { get; set; }

        /// <summary>
        /// Set the starting and ending datetime
        /// </summary>
        public ReadTextFiles()
        {
            IsStartDateFound = false;
            IsEndDateFound = false;
        }

        /// <summary>
        /// Display the data between the starting and the ending datetime
        /// </summary>
        /// <param name="dateAndTimeStart">Starting datetime</param>
        /// <param name="dateAndTimeEnd">Ending datetime</param>
        public void ReadWeatherData(string dateAndTimeStart, string dateAndTimeEnd)
        {
            Console.WriteLine(dateAndTimeStart);

            Console.WriteLine(dateAndTimeEnd);

            #region Set file and user entry
            // file path
            string weatherData2012 = @"E:\Temp\WeatherPond\Environmental_Data_Deep_Moor_2012.txt";

            // read the lines from the text file
            List<string> lines = File.ReadAllLines(weatherData2012).ToList();

            // starting date and time
            string dateStart = this.GetDate(dateAndTimeStart);
            string timeStart = this.GetTime(dateAndTimeStart);

            // ending date and time
            string dateEnd = this.GetDate(dateAndTimeEnd);
            string timeEnd = this.GetTime(dateAndTimeEnd);

            #endregion

            #region Loop through the lines to show data between start and end datetime
            foreach (string line in lines)
            {
                // we don't display the first line (the one which starts with 'date')
                if (!line.StartsWith("date")) 
                {
                    string[] entries = line.Split(Whitespace);
                    WeatherItem weatherItem = new WeatherItem();

                    weatherItem.Date = entries[0];
                    weatherItem.Time = entries[1];

                    // parse the barometric pressure to the type double
                    double barometricPress = 0;
                    double.TryParse(entries[3], out barometricPress);

                    // when the parsing works we associate the value with the weather item
                    weatherItem.BarometricPress = barometricPress;

                    if (weatherItem.Date == dateStart && weatherItem.Time == timeStart)
                    {
                        Console.WriteLine($"Starting point: {weatherItem}");
                        IsStartDateFound = true;
                    } 
                    else if (weatherItem.Date == dateEnd && weatherItem.Time == timeEnd)
                    {
                        Console.WriteLine($"Ending point: {weatherItem}");
                        IsEndDateFound = true;
                    }
                    if (IsStartDateFound && !IsEndDateFound) Console.WriteLine(weatherItem);
                }
            }
            // at the end loop, we reset the finding points to false 
            IsStartDateFound = false;
            IsEndDateFound = false;

            #endregion
        }

        /// <summary>
        /// Get the date from the date and time
        /// </summary>
        /// <param name="dateAndTime">User entry</param>
        /// <returns></returns>
        public string GetDate(string dateAndTime)
        {
            string[] dateAndTimeTab = dateAndTime.Split(Whitespace);
            return dateAndTimeTab[0];
        }

        /// <summary>
        /// Get the time from the date and time
        /// </summary>
        /// <param name="dateAndTime">User entry</param>
        /// <returns></returns>
        public string GetTime(string dateAndTime)
        {
            string[] dateAndTimeTab = dateAndTime.Split(Whitespace);
            return dateAndTimeTab[1];
        }
    }
}
