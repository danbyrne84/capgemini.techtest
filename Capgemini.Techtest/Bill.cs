using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.Techtest
{
    public class Bill
    {
        private readonly IList<MenuItem> _menuItems;

        public Bill()
        {
            _menuItems = new List<MenuItem>();
        }

        public void AddItem(MenuItem item)
        {
            throw new NotImplementedException();
        }

        public decimal CalculateBill()
        {
            throw new NotImplementedException();
        }
    }
}
