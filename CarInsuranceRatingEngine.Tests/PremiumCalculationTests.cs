using System;
using System.Collections.Generic;
using CarInsuranceRatingEngine.Contracts;
using CarInsuranceRatingEngine.Exceptions;
using CarInsuranceRatingEngine.Manufacturers;
using CarInsuranceRatingEngine.Stores;
using CarInsuranceRatingEngine.Validators;
using CarInsuranceRatingEngine.VehicleTypes;
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
            var basePremiumStore = new BasePremiumStore();
            var manufacturerFactorStore = new ManufacturerFactorStore();
            var validators = new List<IValidateVehicle> {new ManufacturerMustExist(manufacturerFactorStore), new VehicleTypeMustExist(basePremiumStore)};
            _premiumCalculator = new PremiumCalculator(basePremiumStore, manufacturerFactorStore, validators);
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

        [Test]
        public void It_should_throw_exceptions_for_non_existing_vehicle_type()
        {
            var truck = new Truck(new Audi());
            Assert.Throws<VehicleTypeNotExistException>(() => _premiumCalculator.Calculate(truck));
        }

        [Test]
        public void It_should_throw_exceptions_for_non_existing_manufacturer()
        {
            var volkswagen = new Car(new Volkswagen());
            Assert.Throws<ManufacturerNotFoundException>(() => _premiumCalculator.Calculate(volkswagen));
        }
    }
}
