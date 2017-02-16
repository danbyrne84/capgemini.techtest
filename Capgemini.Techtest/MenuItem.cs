using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.Techtest
{
    public enum Temperature
    {
        Hot,
        Cold
    }

    public enum ItemType
    {
        Beverage,
        Food
    }
    public class MenuItem
    {
        public string Name { get; set; }
        public Temperature Temperature { get; set; }
        public decimal Price { get; set; }
        public ItemType ItemType { get; set; }
    }
}
