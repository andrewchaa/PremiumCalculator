using CarInsuranceRatingEngine.Exceptions;
using NUnit.Framework;

namespace CarInsuranceRatingEngine.Tests
{
    [TestFixture]
    public class BasePremiumStoreTests
    {
        private BasePremiumStore _store;

        [SetUp]
        public void SetUp()
        {
            _store = new BasePremiumStore();
        }


        [Test]
        public void It_should_get_base_premium_for_car()
        {
            var basePremium = _store.GetBasePremiumFor("Car");

            Assert.That(basePremium, Is.EqualTo(800));
        }

        [Test]
        public void It_should_throw_an_exception_for_non_existing_premium()
        {
            Assert.Throws<VehicleTypeNotExistException>(() => _store.GetBasePremiumFor("NotExistVehicleType"));
        }

        [Test]
        public void It_should_get_base_premium_for_van()
        {
            var basePremium = _store.GetBasePremiumFor("Van");

            Assert.That(basePremium, Is.EqualTo(1000));
        }
    }
}