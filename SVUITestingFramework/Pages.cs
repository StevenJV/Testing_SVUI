using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;

namespace SVUITestingFramework
{
    public static class Pages
    {
        public static Home Home
        {
            get
            {
                var home = new Home();
                PageFactory.InitElements(Browser.Driver, home);
                return home;
            }
        }

        public static Login Login
        {
            get
            {
                var login = new Login();
                PageFactory.InitElements(Browser.Driver, login);
                return login;
            }
        }

        public static Samples Samples
        {
            get
            {
                var samples = new Samples();
                PageFactory.InitElements(Browser.Driver, samples);
                return samples;
            }
        }

        public static Grid Grid
        {
            get
            {
                var grid = new Grid();
                PageFactory.InitElements(Browser.Driver, grid);
                return grid;
            }
        }
    
    }
}
