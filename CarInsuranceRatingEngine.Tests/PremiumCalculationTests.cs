using CarInsuranceRatingEngine.Entities;
using CarInsuranceRatingEngine.Stores;
using NUnit.Framework;

namespace CarInsuranceRatingEngine.Tests
{
    [TestFixture]
    public class PremiumCalculationTests
    {
        [Test]
        public void It_should_calculate_premium_for_Audi_Car()
        {
            var premiumCalculator = new PremiumCalculator(new BasePremiumStore(), new ManufacturerFactorStore());

            var audi = new Car(new Audi());
            var premium = premiumCalculator.Calculate(audi);

            Assert.That(premium, Is.EqualTo(1200));
        }
    }
}
