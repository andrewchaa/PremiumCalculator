﻿using System.Security.AccessControl;
using CarInsuranceRatingEngine.Exceptions;
using CarInsuranceRatingEngine.Manufacturers;
using CarInsuranceRatingEngine.Stores;
using CarInsuranceRatingEngine.VehicleTypes;
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
            var car = new Car(new Audi());
            var basePremium = _store.GetBasePremiumFor(car);

            Assert.That(basePremium, Is.EqualTo(800));
        }

        [Test]
        public void It_should_get_base_premium_for_van()
        {
            var van = new Van(new Audi());
            var basePremium = _store.GetBasePremiumFor(van);

            Assert.That(basePremium, Is.EqualTo(1000));
        }

        [Test]
        public void It_should_throw_an_exception_for_non_existing_premium()
        {
            var truck = new Truck(new Audi());
            Assert.Throws<VehicleTypeNotExistException>(() => _store.GetBasePremiumFor(truck));
        }
    }
}