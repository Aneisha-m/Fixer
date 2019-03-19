using System;
using NUnit.Framework;

namespace Fixer
{
    [TestFixture]
    public class FixerLatestTest
    {
        FixerLatestService fixerLatestService = new FixerLatestService();

        [Test]
        public void WebCallSuccessCheck() => Assert.AreEqual(true, fixerLatestService.fixerLatestDTO.LatestRates.success);
        //DTO Data Transfer Object
  
        // TOTAL RATES CHECK
        [Test]
        public void TotalRatesCheck() => Assert.AreEqual(168, fixerLatestService.CountRates());

        // DATE CHECK
        [Test]
        public void DateCheck() => Assert.AreEqual(DateTime.Now.ToString("yyyy'-'MM'-'dd"), fixerLatestService.fixerLatestDTO.LatestRates.date);

        // BASE CHECK
        [Test]
        public void BaseCheck()
        {
            TestContext.Out.WriteLine(fixerLatestService.LatestRatesJson.ToString());
            Assert.AreEqual("EUR", fixerLatestService.LatestRatesJson["base"].ToString());
        }

        // ALL RATES ARE FLOATS
        // TIMESTAMP CHECK

    }
}

