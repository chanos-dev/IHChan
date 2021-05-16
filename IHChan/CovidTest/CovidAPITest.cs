using System;
using IHChan.APIs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CovidTest
{
    [TestClass]
    public class CovidAPITest
    {
        private CovidController covid { get; set; } = new CovidController();
        [TestMethod]
        public void GetHomeCountryCovidState()
        { 
            //covid.GetHomeCountryCovidState($"{DateTime.Now:d}", $"{DateTime.Now:d}");
            var results = covid.GetHomeCountryCovidState("2021-05-12", "20210513");
            
        }

        [TestMethod]
        public void GetSidoCovidState()
        {
            var results = covid.GetSidoCovidState("2021-05-12", "20210513");
        }

        [TestMethod]
        public void GetOverseasCovidState()
        {
            var results = covid.GetOverseasCovidState("2021-05-12", "20210513");
        }
    }
}
