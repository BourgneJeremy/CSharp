using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherPond.Controller;

namespace WeatherPondTestProject
{
    [TestClass]
    public class MenuTests
    {
        /// <summary>
        /// Test the gap with the values 2012 and 2015
        /// </summary>
        [TestMethod]
        public void ComputeGapTest()
        {
            // Arrange
            int startYear = 2012;
            int endYear = 2015;
            Menu menu = new Menu();

            int expectedGap = 3;

            // Act
            int resultGap = menu.ComputeGap(startYear, endYear);

            // Assert
            Assert.AreEqual(expectedGap, resultGap, "Expected the values 2012 and 2015 of ComputeGap to be equal to 3");
        }
    }
}
