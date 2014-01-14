using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVUITestingFramework
{
    public class Home
    {
        private static string Url = "http://sv-ui.herokuapp.com/";

        public void Goto()
        {
            Browser.Goto(Url);
        }
    }

}

