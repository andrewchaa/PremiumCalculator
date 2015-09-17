using CarInsuranceRatingEngine.Entities;
using CarInsuranceRatingEngine.Stores;
using NUnit.Framework;

namespace CarInsuranceRatingEngine.Tests
{
    [TestFixture]
    public class PremiumCalculationTests
    {
        private PremiumCalculator _premiumCalculator;

        [SetUp]
        public void SetUp()
        {
            _premiumCalculator = new PremiumCalculator(new BasePremiumStore(), new ManufacturerFactorStore());
        }

        [Test]
        public void It_should_calculate_premium_for_Audi_Car()
        {
            var audiCar = new Car(new Audi());
            var premium = _premiumCalculator.Calculate(audiCar);

            Assert.That(premium, Is.EqualTo(1200));
        }

        [Test]
        public void It_should_calculate_premium_for_Audi_Van()
        {
            var audiVan = new Van(new Audi());
            var premium = _premiumCalculator.Calculate(audiVan);

            Assert.That(premium, Is.EqualTo(1500));
        }

        [Test]
        public void It_should_calculate_premium_for_Mercedes_Car()
        {
            var mercedesCar = new Car(new Mercedes());
            var premium = _premiumCalculator.Calculate(mercedesCar);

            Assert.That(premium, Is.EqualTo(1600));
        }

        [Test]
        public void It_should_calculate_premium_for_Mercedes_Van()
        {
            var mercedesVan = new Van(new Mercedes());
            var premium = _premiumCalculator.Calculate(mercedesVan);

            Assert.That(premium, Is.EqualTo(2000));
        }
    }
}
