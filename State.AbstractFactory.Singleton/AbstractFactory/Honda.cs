using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.AbstractFactory.Singleton
{
   public class Honda:ICar
    {
        public void About()
        {
            Console.WriteLine("Honda-USA Factory");
        }
    }
}
