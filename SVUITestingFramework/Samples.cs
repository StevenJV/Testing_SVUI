using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVUITestingFramework
{
    public class Samples
    {
        private static string PageTitle = "User Interface Samples";
        private static string Url = "http://sv-ui.herokuapp.com/default.html";

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }
        public void Goto()
        {
            Browser.Goto(Url);
        }
    }
}
