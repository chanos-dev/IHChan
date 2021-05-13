using System;
using IHChan.APIs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CovidTest
{
    [TestClass]
    public class CovidAPITest
    {
        [TestMethod]
        public void GetHomeCountryCovidState()
        {
            var covid = new CovidController();

            //covid.GetHomeCountryCovidState($"{DateTime.Now:d}", $"{DateTime.Now:d}");
            var results = covid.GetHomeCountryCovidState("2021-05-12", "20210513");


        }
    }
}
