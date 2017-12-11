using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.AbstractFactory.Singleton
{
  public class Class
    {
        private static  Class value;
        public static Class GetValue ()
        {
            if (value == null)
            {
                value = new Class();
            }
            return value;
        }
       
        private Class()
        {

        }
        public string Write()
        {
          return "Sigleton";
        }
    }
}
