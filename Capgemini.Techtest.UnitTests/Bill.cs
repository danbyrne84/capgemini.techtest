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
    }
}
