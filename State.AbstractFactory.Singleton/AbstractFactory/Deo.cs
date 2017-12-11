using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.AbstractFactory.Singleton
{
    public class Deo : ICar
    {
        public void About()
        {
            Console.WriteLine("Deo PolandFactory");
        }
    }
}
