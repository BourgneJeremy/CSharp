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
        public List<WeatherItem> ReadYear(string dateAndTimeStart, string dateAndTimeEnd)
        {
            #region Set file and user entry

            string year = dateAndTimeStart.Split('_')[0];

            // file path
            string weatherData2012 = $"E:\\Temp\\WeatherPond\\Environmental_Data_Deep_Moor_{year}.txt";

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

            // Setup a list of weatherItems
            List<WeatherItem> weatherItems = new List<WeatherItem>();

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

                    if (weatherItem.Date == dateStart && weatherItem.Time.StartsWith(timeStart) && !IsStartDateFound)
                    {
                        // Console.WriteLine($"Starting point: {weatherItem}");
                        // -------- CHANGE
                        // weatherItems.Add(weatherItem);
                        IsStartDateFound = true;
                    } 
                    else if (weatherItem.Date == dateEnd && weatherItem.Time.StartsWith(timeEnd))
                    {
                        // Console.WriteLine($"Ending point: {weatherItem}");
                        weatherItems.Add(weatherItem);
                        IsEndDateFound = true;
                    }
                    if (IsStartDateFound && !IsEndDateFound) weatherItems.Add(weatherItem);
                }
            }
            // at the end loop, we reset the finding points to false 
            IsStartDateFound = false;
            IsEndDateFound = false;

            return weatherItems;
            #endregion
        }

        /// <summary>
        /// Read the passed in parameter
        /// </summary>
        /// <param name="year">The current year</param>
        /// <returns></returns>
        public List<WeatherItem> ReadFullYear(int year)
        {
            // file path
            string weatherData = $"E:\\Temp\\WeatherPond\\Environmental_Data_Deep_Moor_{year}.txt";

            // read the lines from the text file
            List<string> lines = File.ReadAllLines(weatherData).ToList();

            // Setup a list of weatherItems
            List<WeatherItem> weatherItems = new List<WeatherItem>();

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

                    weatherItems.Add(weatherItem);
                }
            }
            return weatherItems;
        }

        /// <summary>
        /// Read the specific start to the end of the file
        /// </summary>
        /// <param name="dateAndTimeStart">Start date and time</param>
        /// <returns></returns>
        public List<WeatherItem> ReadYearStart(string dateAndTimeStart)
        {
            string date = dateAndTimeStart.Split(Whitespace)[0];
            string time = dateAndTimeStart.Split(Whitespace)[1];

            // get the year
            string year = date.Split('_')[0];
            string month = date.Split('_')[1];
            string day = date.Split('_')[2];

            // read the file of the year
            // file path
            string weatherData = $"E:\\Temp\\WeatherPond\\Environmental_Data_Deep_Moor_{year}.txt";

            // read the lines from the text file
            List<string> lines = File.ReadAllLines(weatherData).ToList();

            // Setup a list of weatherItems
            List<WeatherItem> weatherItems = new List<WeatherItem>();

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

                    // start the reading when you encounter the dateAndTimeStart
                    if (weatherItem.Date == date && weatherItem.Time.StartsWith(time) && !IsStartDateFound)
                    {
                        IsStartDateFound = true;
                    }
                    if (IsStartDateFound)
                    {
                        weatherItems.Add(weatherItem);
                    }
                }
            }
            // reset before sending
            IsStartDateFound = false;

            return weatherItems;
        }

        /// <summary>
        /// Read the specific end to the end of the file
        /// </summary>
        /// <param name="dateAndTimeEnd">End date and time</param>
        /// <returns></returns>
        public List<WeatherItem> ReadYearEnd(string dateAndTimeEnd)
        {
            string date = dateAndTimeEnd.Split(Whitespace)[0];
            string time = dateAndTimeEnd.Split(Whitespace)[1];

            // get the year
            string year = date.Split('_')[0];
            string month = date.Split('_')[1];
            string day = date.Split('_')[2];

            // read the file of the year
            // file path
            string weatherData = $"E:\\Temp\\WeatherPond\\Environmental_Data_Deep_Moor_{year}.txt";

            // read the lines from the text file
            List<string> lines = File.ReadAllLines(weatherData).ToList();

            // Setup a list of weatherItems
            List<WeatherItem> weatherItems = new List<WeatherItem>();

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

                    // start the reading when you encounter the dateAndTimeStart
                    if (weatherItem.Date == date && weatherItem.Time.StartsWith(time) && !IsEndDateFound)
                    {
                        IsEndDateFound = true;
                    }
                    if (!IsEndDateFound)
                    {
                        weatherItems.Add(weatherItem);
                    }
                }
            }
            // reset before sending
            IsStartDateFound = false;

            return weatherItems;
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

        /// <summary>
        /// Display the weather items
        /// </summary>
        /// <param name="weatherItems">Result list</param>
        public void DisplayItems(List<WeatherItem> weatherItems)
        {
            foreach (WeatherItem weather in weatherItems)
            {
                Console.WriteLine(weather);
            }

            /*for (int i = 0; i < weatherItems.Count; i++)
            {
                if (i == 0 || i == weatherItems.Count - 1)
                {
                    Console.WriteLine(weatherItems[i]);
                }
            }*/

            Console.ReadLine();
        }
    }
}
