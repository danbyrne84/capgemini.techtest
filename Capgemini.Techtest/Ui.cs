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

        public Ui(Menu menu, Bill bill)
        {
            _menu = menu;
            _bill = bill;
        }

        private string PromptForMenuItem()
        {
            throw new NotImplementedException();
        }

        private MenuItem FindMenuItem()
        {
            throw new NotImplementedException();
        }

        public void Go()
        {
            throw new NotImplementedException();
        }
    }
}
