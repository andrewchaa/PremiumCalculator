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
            var premium = calculator.CalculatePremium("Car", "Audi");

            Assert.That(premium, Is.EqualTo(1200));
        }
    }

    public class RateCalculator
    {
        public double CalculatePremium(string vehicleType, string manufacturer)
        {
            var basePremium = GetBasePremiumFor(vehicleType);
            var factor = GetFactorFor(manufacturer);
            return basePremium * factor;
        }

        private double GetFactorFor(string manufacturer)
        {
            return 1.5;
        }

        private double GetBasePremiumFor(string vehicleType)
        {
            return 800;
        }
    }
}
