using System;
using System.Collections.Generic;
using System.Linq;
using azure_cicd_test;
using azure_cicd_test.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace WeatherAPI.Tests {
    public class WeatherForecastTests : IDisposable {
        WeatherForecastController controller;

        public WeatherForecastTests () {

            controller = new WeatherForecastController (null);
        }

        public void Dispose () {
            controller = null;
        }

        [Fact]
        public void GetWeatherForecastItemsReturnsNotNull () {
            //Arrange

            //Act
            var result = controller.Get ();

            //Assert
            Assert.Null (result);
        }

    }
}