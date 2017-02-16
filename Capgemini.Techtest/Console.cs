using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.Techtest
{
    public class Console : IConsole
    {
        public void WriteLine(string output)
        {
            System.Console.WriteLine(output);
        }

        public string ReadLine()
        {
            return System.Console.ReadLine();
        }
    }
}
