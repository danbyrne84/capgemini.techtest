using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Capgemini.Techtest.UnitTests
{
    [TestClass]
    public class Ui
    {
        private Techtest.Menu _menu;
        private Techtest.Bill _bill;
        private Techtest.Ui _underTest;

        [TestInitialize]
        public void Setup()
        {
            _menu = new Menu(new List<MenuItem>()
            {
                new MenuItem()
                {
                    Name = "Cola",
                    Price = 0.50m,
                    Temperature = Temperature.Cold,
                },
                new MenuItem()
                {
                    Name = "Coffee",
                    Price = 1.00m,
                    Temperature = Temperature.Hot,
                },
                new MenuItem()
                {
                    Name = "Cheese Sandwich",
                    Price = 2.00m,
                    Temperature = Temperature.Cold
                }
            });

            _bill = new Techtest.Bill();
            _underTest = new Techtest.Ui(_menu, _bill, new Console());
        }
        

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Initialize_GivenMissingMenuDependency_Assert_ExceptionThrown()
        {
            var ui = new Techtest.Ui(null, new Techtest.Bill(), new Console());
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Initialize_GivenMissingBillDependency_Assert_ExceptionThrown()
        {
            var menu = new Menu(new List<MenuItem>());
            var ui = new Techtest.Ui(menu, null, new Console());
        }

        [TestMethod]
        public void FindMenuItem_GivenMenuItemFoundInMenu_Assert_MenuItemReturned()
        {
            var searchResult = _underTest.TryAddMenuItem("cheese sandwich");
            Assert.AreNotEqual(null, searchResult);

            Assert.IsTrue(searchResult.Name.Equals("Cheese Sandwich"));
            Assert.IsTrue(searchResult.Price.Equals(2.00m));
            Assert.IsTrue(searchResult.Temperature.Equals(Temperature.Cold));
        }

        [TestMethod]
        public void FindMenuItem_GivenMenuItemNotFound_Assert_NullReturned()
        {
            var searchResult = _underTest.TryAddMenuItem("lego");
            Assert.AreEqual(null, searchResult);
        }

        [TestMethod]
        public void FindMenuItem_GivenMenuItemFound_Assert_MenuItemAddedToBill()
        {
            var searchResult = _underTest.TryAddMenuItem("cola");

            Assert.AreEqual(1, _bill.MenuItems.Count);
            Assert.IsTrue(_bill.MenuItems.First().Name.Equals("Cola"));
        }
    }
}
