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
                var Home = new Home();
                PageFactory.InitElements(Browser.Driver, Home);
                return Home;
            }
        }

        public static Login Login
        {
            get
            {
                var Login = new Login();
                PageFactory.InitElements(Browser.Driver, Login);
                return Login;
            }
        }

        public static Samples Samples
        {
            get
            {
                var Login = new Samples();
                PageFactory.InitElements(Browser.Driver, Samples);
                return Samples;
            }
        }
    }
}
