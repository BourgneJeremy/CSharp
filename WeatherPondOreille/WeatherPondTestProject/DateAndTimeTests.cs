using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherPond.Controller;

namespace WeatherPondTestProject
{
    [TestClass]
    public class DateAndTimeTests
    {
        #region Convert date for weather test
        [TestMethod]
        public void ConvertDateForWeatherTest()
        {
            // Arrange
            string date = "02/08/2012";
            string expectedDate = "2012_08_02";
            DateAndTime dt = new DateAndTime();

            // Act
            string resultDate = dt.ConvertDateForWeather(date);

            // Assert
            Assert.AreEqual(expectedDate, resultDate, "Expected 02/08/2012 to be 2012_08_02");
        }

        [TestMethod]
        public void ConvertDateForWeatherTest_DoesNotReturnCorrectString()
        {
            // Arrange
            string date = "0208/2012";
            string expectedDate = "2012_08_02";
            DateAndTime dt = new DateAndTime();

            // Act
            string resultDate = dt.ConvertDateForWeather(date);

            // Assert
            Assert.AreNotEqual(expectedDate, resultDate, "Expected 02/08/2012 to be 2012_08_02");
        }
        #endregion

        #region Convert time for weather test
        [TestMethod]
        public void ConvertTimeForWeatherTest()
        {
            // Arrange
            string time = "10:29:03";
            string expectedTime = "10:29:03";
            DateAndTime dt = new DateAndTime();

            // Act
            string resultTime = dt.ConvertTimeForWeather(time);

            // Assert
            Assert.AreEqual(expectedTime, resultTime, "Expected 10:29:03 to be 10:29:03");
        }
        
        [TestMethod]
        public void ConvertTimeForWeatherTest_DoesNotReturnCorrectString()
        {
            // Arrange
            string time = "10:29:15";
            string expectedTime = "10:29:03";
            DateAndTime dt = new DateAndTime();

            // Act
            string resultTime = dt.ConvertTimeForWeather(time);

            // Assert
            Assert.AreNotEqual(expectedTime, resultTime, "Expected not correct string");
        }
        #endregion

        #region Read user date and time
        [TestMethod]
        public void ReadUserDateAndTimeTest()
        {
            // Arrange
            string date = "23/09/2012";
            string time = "08:18:08";
            string expectedDateAndTime = "2012_09_23 08:18:08";
            DateAndTime dt = new DateAndTime();

            // Act
            string dateAndTimeResult = dt.ReadUserDateAndTime(date, time);

            // Assert
            Assert.AreEqual(expectedDateAndTime, dateAndTimeResult, "Expected [date: 23/09/2012; time: 08:18:08] to be 2012_09_23 08:18:08");
        }
        
        [TestMethod]
        public void ReadUserDateAndTimeTest_DoesNotReturnCorrectString()
        {
            // Arrange
            string date = "23_09_2012";
            string time = "08:18:08";
            string expectedDateAndTime = "2012_09_23 08:18:08";
            DateAndTime dt = new DateAndTime();

            // Act
            string dateAndTimeResult = dt.ReadUserDateAndTime(date, time);

            // Assert
            Assert.AreNotEqual(expectedDateAndTime, dateAndTimeResult, "Expected [date: 23_09_2012; time: 08:18:08] to be false");
        }
        #endregion
    }
}
