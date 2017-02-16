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
            _menuItems.Add(item);
        }

        public decimal CalculateBill()
        {
            return _menuItems.Sum(x => x.Price);
        }
    }
}
