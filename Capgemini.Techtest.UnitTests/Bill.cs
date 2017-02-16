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
        public void CalculateBill_Given_MenuConsistsOfAColaCoffeeAndCheeseSandwich_Assert_BillShouldBe350()
        {
            var cola = new MenuItem()
            {
                Name = "Cola",
                Price = 0.50m,
                Temperature = Temperature.Cold,
            };

            var coffee = new MenuItem()
            {
                Name = "Coffee",
                Price = 1.00m,
                Temperature = Temperature.Hot,
            };

            var cheeseSandwich = new MenuItem()
            {
                Name = "Cheese Sandwich",
                Price = 2.00m,
                Temperature = Temperature.Cold,
            };

            _underTest.AddItem(cola);
            _underTest.AddItem(coffee);
            _underTest.AddItem(cheeseSandwich);

            Assert.AreEqual(3.50m, _underTest.CalculateBill());
        }

    }
}
