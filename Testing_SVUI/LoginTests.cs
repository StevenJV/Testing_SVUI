using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SVUITestingFramework;

namespace Testing_SVUI
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void Defaults_To_Login()
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

        [TestCleanup]
        public void CleanUp()
        {
            // Browser.Close();
        }
    }
}
