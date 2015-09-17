using CarInsuranceRatingEngine.Entities;
using NUnit.Framework;

namespace CarInsuranceRatingEngine.Tests
{
    [TestFixture]
    public class PremiumCalculationTests
    {
        [Test]
        public void It_should_calculate_premium_for_Audi_Car()
        {
            var premiumCalculator = new PremiumCalculator(new BasePremiumStore());

            var audi = new Car("Audi");
            var premium = premiumCalculator.Calculate(audi);

            Assert.That(premium, Is.EqualTo(1200));
        }
    }
}
