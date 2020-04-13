using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherPond.Controller;

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
            string dateAndTime = "2012_03_51 18:45:26";
            string expectedTime = "18:45:26";
            ReadTextFiles rd = new ReadTextFiles();

            // Act
            string resultTime = rd.GetTime(dateAndTime);

            // Assert
            Assert.AreEqual(expectedTime, resultTime);
        }
        #endregion
    }
}
