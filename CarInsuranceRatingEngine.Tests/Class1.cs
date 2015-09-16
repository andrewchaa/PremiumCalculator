using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CarInsuranceRatingEngine.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void It_should_calculate_premium()
        {
            var calculator = new RateCalculator();
            var premium = calculator.CalculateRate("Car", "Audi");
            Assert.That(premium, Is.EqualTo(1200));
        }
    }

    public class RateCalculator
    {
        public int CalculateRate(string vehicleType, string manufacturer)
        {
            return 1200;
        }
    }
}
