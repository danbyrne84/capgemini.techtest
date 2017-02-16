using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.Techtest
{
    public class Bill
    {
        public IList<MenuItem> MenuItems { get; }

        public int ServiceCharge
        {
            get { throw new NotImplementedException(); }
        }

        public Bill()
        {
            MenuItems = new List<MenuItem>();
        }

        public void AddItem(MenuItem item)
        {
            MenuItems.Add(item);
        }

        public decimal CalculateBill()
        {
            return MenuItems.Sum(x => x.Price);
        }
    }
}
