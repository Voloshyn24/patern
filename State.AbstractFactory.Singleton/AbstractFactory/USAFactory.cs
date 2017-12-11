using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.AbstractFactory.Singleton
{
   public class USAFactory: IAbstractFactory
    {
        public IBike ReturnBike()
        {
            return new BMW();
        }

        public ICar ReturnCar()
        {
            return new Honda();
        }
    }
}
