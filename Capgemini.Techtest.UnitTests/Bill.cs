using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Capgemini.Techtest.UnitTests
{
    [TestClass]
    public class Bill
    {
        private Capgemini.Techtest.Bill _underTest;
        private Capgemini.Techtest.Menu _menu;

        [TestInitialize]
        public void Setup()
        {
            _underTest = new Capgemini.Techtest.Bill();
            _menu = new Menu(new List<MenuItem>());
        }

        [TestMethod]
        public void Initialize_BillTotalShouldBeZero()
        {
            Assert.AreEqual(0m, _underTest.CalculateBill());
        }

        [TestMethod]
        public void CalculateBill_Given_MenuConsistsOfAColaCoffeeAndCheeseSandwich_Assert_BillShouldBe385()
        {
            var cola = new MenuItem()
            {
                Name = "Cola",
                Price = 0.50m,
                Temperature = Temperature.Cold,
                ItemType = ItemType.Beverage
            };

            var coffee = new MenuItem()
            {
                Name = "Coffee",
                Price = 1.00m,
                Temperature = Temperature.Hot,
                ItemType = ItemType.Beverage
            };

            var cheeseSandwich = new MenuItem()
            {
                Name = "Cheese Sandwich",
                Price = 2.00m,
                Temperature = Temperature.Cold,
                ItemType = ItemType.Food
            };

            _underTest.AddItem(cola);
            _underTest.AddItem(coffee);
            _underTest.AddItem(cheeseSandwich);

            Assert.AreEqual(3.85m, _underTest.CalculateBill());
        }

        [TestMethod]
        public void CalculateBill_Given_MenuConsistsOfAllDrinks_Assert_ServiceChargeZeroPercent()
        {
            var cola = new MenuItem()
            {
                Name = "Cola",
                Price = 0.50m,
                Temperature = Temperature.Cold,
                ItemType = ItemType.Beverage
            };

            _underTest.AddItem(cola);

            Assert.AreEqual(0, _underTest.ServiceCharge);
            Assert.AreEqual(0.50m, _underTest.CalculateBill());
        }

        [TestMethod]
        public void CalculateBill_Given_MenuConsistsOfAtLeastOneFoodItem_AndNoHotFood_ServiceChargeTenPercent()
        {
            var cola = new MenuItem()
            {
                Name = "Cola",
                Price = 0.50m,
                Temperature = Temperature.Cold,
                ItemType = ItemType.Beverage
            };

            var cheeseSandwich = new MenuItem()
            {
                Name = "Cheese Sandwich",
                Price = 2.00m,
                Temperature = Temperature.Cold,
                ItemType = ItemType.Food
            };

            _underTest.AddItem(cola);
            _underTest.AddItem(cheeseSandwich);

            Assert.AreEqual(0.25m, _underTest.ServiceCharge);
            Assert.AreEqual(2.75m, _underTest.CalculateBill());
        }

        [TestMethod]
        public void CalculateBill_Given_MenuConsistsOfAtLeastOneHotFoodItem_ServiceChargeTwentyPercent()
        {
            var cola = new MenuItem()
            {
                Name = "Cola",
                Price = 0.50m,
                Temperature = Temperature.Cold,
                ItemType = ItemType.Beverage
            };

            var steakSandwich = new MenuItem()
            {
                Name = "Steak Sandwich",
                Price = 4.50m,
                Temperature = Temperature.Hot,
                ItemType = ItemType.Food
            };

            _underTest.AddItem(cola);
            _underTest.AddItem(steakSandwich);

            Assert.AreEqual(1.0m, _underTest.ServiceCharge);
            Assert.AreEqual(6.0m, _underTest.CalculateBill());
        }
    }
}
