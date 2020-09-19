using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialFlorenciaRamirez.Controllers;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetCountry()
        {
            //Arrange
            CountriesController countriesController = new CountriesController();

            //Act
            var ListCountries = countriesController.GetCountries();

            //Assert
            Assert.IsNotNull(ListCountries);
        }
    }
}
