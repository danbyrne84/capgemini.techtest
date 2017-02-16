﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.Techtest
{
    class Program
    {
        static void Main(string[] args)
        {
            // set up our initial list of menu items
            var menuItems = new List<MenuItem>()
            {
                new MenuItem()
                {
                    Name = "cola",
                    Temperature = Temperature.Cold,
                    Price = 0.50m
                },
                new MenuItem()
                {
                    Name = "coffee",
                    Temperature = Temperature.Hot,
                    Price = 1.00m
                },
                new MenuItem()
                {
                    Name = "cheese sandwich",
                    Temperature = Temperature.Cold,
                    Price = 2.00m
                },
                new MenuItem()
                {
                    Name = "steak sandwich",
                    Temperature = Temperature.Hot,
                    Price = 4.50m
                }
            };

            // initialise the UI
            var ui = new Ui(new Menu(menuItems), new Bill(), new Console());
            ui.Go();
        }
    }
}
