using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.AbstractFactory.Singleton
{
    public interface IAbstractFactory
    {
      ICar ReturnCar();
      IBike ReturnBike();   
    }
}
