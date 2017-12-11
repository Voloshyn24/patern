using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.AbstractFactory.Singleton
{
  public class Adapter:IPageList
    {
        Printer printer = new Printer();
        public void Print(List<string> ListPage)
        {
            foreach (string n in ListPage)
            {

                printer.Copy(n);
            }
        }
    }
}
