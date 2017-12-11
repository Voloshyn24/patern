using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.AbstractFactory.Singleton
{
  public class PolandFactory: IAbstractFactory
    {
        public ICar ReturnCar()
        {
            return new Deo();
        }

        public IBike ReturnBike()
        {
            return new Woshod();
        }

    }
}
