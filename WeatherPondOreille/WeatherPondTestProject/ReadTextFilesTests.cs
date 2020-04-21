using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherPondClass.Controller;
using WeatherPondClass.Model;

namespace WeatherPondTestProject
{
    [TestClass]
    public class ReadTextFilesTests
    {
        #region Get date and time from dateAndTime tests
        [TestMethod]
        public void GetDateTest()
        {
            // Arrange
            string dateAndTime = "2012_09_21 18:50:26";
            string expectedDate = "2012_09_21";
            ReadTextFiles rd = new ReadTextFiles();

            // Act
            string resultDate = rd.GetDate(dateAndTime);

            // Assert
            Assert.AreEqual(expectedDate, resultDate);
        }
        
        [TestMethod]
        public void GetTimeTest()
        {
            // Arrange
            string dateAndTime = "2012_03_51 18";
            string expectedTime = "18";
            ReadTextFiles rd = new ReadTextFiles();

            // Act
            string resultTime = rd.GetTime(dateAndTime);

            // Assert
            Assert.AreEqual(expectedTime, resultTime);
        }
        #endregion

        #region Check if test data is equal to the data read into the text file
        [TestMethod]
        public void ReadWeatherDataTest()
        {
            // Arrange
            string startDateAndTime = "2012_08_19 21";
            string endDateAndTime = "2012_08_19 22";

            ReadTextFiles rd = new ReadTextFiles();

            List<WeatherItem> expectedWeatherItems = WeatherData();

            // Act
            List<WeatherItem> weatherItemsResult = rd.ReadYear(startDateAndTime, endDateAndTime);

            // Assert
            for (int i = 0; i < expectedWeatherItems.Count; i++)
            {
                Assert.AreEqual(expectedWeatherItems[i].ToString(), weatherItemsResult[i].ToString());
            }
        }

        private List<WeatherItem> WeatherData()
        {
            // Create three data items
            List<WeatherItem> weatherItems = new List<WeatherItem>();
            weatherItems.Add(new WeatherItem("2012_08_19", "21:02:47", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "21:09:03", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "21:15:19", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "21:21:35", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "21:27:50", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "21:34:06", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "21:40:37", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "21:47:34", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "21:53:55", 29.8));

            weatherItems.Add(new WeatherItem("2012_08_19", "22:00:11", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "22:06:27", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "22:12:43", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "22:18:58", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "22:25:17", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "22:31:32", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "22:37:48", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "22:44:04", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "22:50:20", 29.8));
            weatherItems.Add(new WeatherItem("2012_08_19", "22:56:36", 29.8));

            return weatherItems;
        }
        #endregion
    }
}
