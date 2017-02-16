using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.Techtest
{
    public class Menu
    {
        public IList<MenuItem> Items;

        public Menu(IList<MenuItem> items)
        {
            Items = items;
        }
    }
}
