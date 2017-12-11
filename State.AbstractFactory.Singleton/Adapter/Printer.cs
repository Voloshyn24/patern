using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.AbstractFactory.Singleton
{
    class Printer
    {
        public void Copy(string page)
        {
            Console.WriteLine(page);
        }
    }
}
