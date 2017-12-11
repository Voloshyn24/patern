using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.AbstractFactory.Singleton
{
   public class User
    {
      static  IPageList adapter = new Adapter();
      static List<string> Pages = new List<string>();
        public static void Calc()
        {
            Pages.Add("1");
            Pages.Add("2");
            Pages.Add("3");
            adapter.Print(Pages);
        }

    }
}
