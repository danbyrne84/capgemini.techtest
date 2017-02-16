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

        public decimal ServiceCharge
        {
            get
            {
                if (MenuItems.Any(mi => mi.ItemType == ItemType.Food && mi.Temperature == Temperature.Hot))
                {
                    // 20% service charge for hot food
                    return Math.Round((CalculateBill(false) / 100 * 20), 2);
                }

                if (MenuItems.Any(mi => mi.ItemType == ItemType.Food))
                {
                    // else 10% charge for including food
                    return Math.Round((CalculateBill(false) / 100 * 10), 2);
                }

                return 0;
            }
        }

        public Bill()
        {
            MenuItems = new List<MenuItem>();
        }

        public void AddItem(MenuItem item)
        {
            MenuItems.Add(item);
        }

        public decimal CalculateBill(bool includeServiceCharge = true)
        {
            var basePrice = MenuItems.Sum(x => x.Price);

            if (includeServiceCharge)
            {
                basePrice += ServiceCharge;
            }

            return basePrice;
        }
    }
}
