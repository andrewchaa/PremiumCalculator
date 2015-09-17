using CarInsuranceRatingEngine.Exceptions;
using CarInsuranceRatingEngine.Manufacturers;
using CarInsuranceRatingEngine.Stores;
using NUnit.Framework;

namespace CarInsuranceRatingEngine.Tests
{
    [TestFixture]
    public class ManufacturerFactorStoreTests
    {
        private ManufacturerFactorStore _store;

        [SetUp]
        public void SetUp()
        {
            _store = new ManufacturerFactorStore();
        }

        [Test]
        public void It_should_get_manufacturer_factor_for_Audi()
        {
            var factor = _store.GetFactorFor(new Audi());

            Assert.That(factor, Is.EqualTo(1.5));
        }

        [Test]
        public void It_should_get_manufacturer_factor_for_Mercedes()
        {
            var factor = _store.GetFactorFor(new Mercedes());

            Assert.That(factor, Is.EqualTo(2.0));
        }

        [Test]
        public void It_should_throw_manufacturer_not_found_exception_given_unknown_facturer()
        {
            Assert.Throws<ManufacturerNotFoundException>(() => _store.GetFactorFor(new Volkswagen()));
        }
    }
}