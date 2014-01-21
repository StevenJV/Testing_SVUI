using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SVUITestingFramework;

namespace Testing_SVUI
{
    [TestClass]
    public class DataTests
    {

        [TestMethod]
        public void BMW_Filter_Shows_Two_Cars()
            // note: this is just for a simple demonstration, not something I would 
            // normally do, for two reasons.
            // First of all, this demo site uses Kendo UI for the grid. Filtering
            // is a function of that product.  If a development team doesn't trust 
            // that the third-party product works corectly, they shouldn't use it. 
            // Secondly, this test is extremely dependant on the data; it assumes
            // that there will only ever be two records for this make of vehicle.
            // A better way would be to verify that all the rows returned actually
            // are correct ones, no matter how many. 
        {
            Pages.Grid.Goto();
            Pages.Grid.FilterByBMW();
            Assert.IsTrue(2 == Pages.Grid.CountRows());
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            Browser.Close();
        }
    }


    [TestClass]
    public class LoginTests
    {

        [TestMethod]
        public void Defaults_To_Login()
            // this test is making sure that the site is set up correctly, not
            // really testing the site's code. That's ok, it is likely an important
            // thing to be testing anyway. 
        {
            Pages.Home.Goto();
            Assert.IsTrue(Pages.Login.IsAt());
        }

        [TestMethod]
        public void Login_With_Correct_Credentials_Goes_To_Default_Page()
        {
            // correct login credentials Username/abc123 should result in default page being displayed
            Pages.Login.Goto();
            Pages.Login.LoginWith("Username", "abc123");
            Assert.IsTrue(Pages.Samples.IsAt());
        }

        [TestMethod]
        public void Login_With_incorrect_Credentials_Returns_Proper_Message()
        {
            // incorrect login credentials should result in message being displayed on login screen.
            Pages.Login.Goto();
            Pages.Login.LoginWith("BadUsername", "BadPassword");
            Assert.IsTrue(Pages.Login.DisplaysInvalidUnPwMessage());
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            Browser.Close();
        }
    }
}
