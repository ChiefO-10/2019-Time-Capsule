using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEventsSandbox
{
    class ConsoleAlerter
    {
        public void AddingProductAlert (object sender, EventArgs e)
        {
            Console.WriteLine("Adding product to list..");
        }
        public void AddedProductAlert (object sender, string e)
        {
            Console.WriteLine($"Sucesfully added {e}!");
        }
    }
}
