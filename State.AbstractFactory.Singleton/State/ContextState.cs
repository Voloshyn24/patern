using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.AbstractFactory.Singleton
{
   public  class ContextState
    {

        public IState Istate { get; set; }
        public void AllAction()
        {
               Istate.Action();
        }

    }
}
