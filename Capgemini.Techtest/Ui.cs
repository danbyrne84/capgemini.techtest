using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.Techtest
{
    public class Ui
    {
        private readonly Menu _menu;
        private readonly Bill _bill;
        private readonly IConsole _console;

        public Ui(Menu menu, Bill bill, IConsole console)
        {
            if (menu == null) { throw new ArgumentNullException("menu"); }
            if (bill == null) { throw new ArgumentNullException("bill"); }
            if (console == null) { throw new ArgumentNullException("console"); }

            _menu = menu;
            _bill = bill;
            _console = console;
        }

        private string PromptForMenuItem()
        {
            _console.WriteLine("Please enter a menu item, or press enter to complete the bill.");
            return _console.ReadLine();
        }

        public MenuItem TryAddMenuItem(string name)
        {
            var item = _menu.Items.FirstOrDefault(itm => itm.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
            if (item != null)
            {
                _bill.AddItem(item);
            }

            return item;
        }

        public void Go()
        {
            _console.WriteLine($"Available menu items are [{string.Join(",", _menu.Items.Select(mi => mi.Name))}]");

            string chosenItem;
            while ((chosenItem = PromptForMenuItem()) != string.Empty)
            {
                // find menu item
                var item = TryAddMenuItem(chosenItem);
                if (item == null)
                {
                    _console.WriteLine($"Unable to find the menu item {chosenItem}");
                }
                else
                {
                    _console.WriteLine($"{item.Name} @ {item.Price} added to the bill");
                }
            }

            _console.WriteLine($"Thankyou, your bill comes to {_bill.CalculateBill()}");
            _console.WriteLine("Press any key to end");
            _console.ReadLine();
        }
    }
}
