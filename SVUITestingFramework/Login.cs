using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SVUITestingFramework
{

    public class Login
    {
        private static string PageTitle = "Login: User Interface Samples";
        private static string Url = "http://sv-ui.herokuapp.com/";
        private static string InvalidLoginMessage = "invalid username/password pair.";

        [FindsBy(How = How.Id, Using = "message")]
        private IWebElement message;

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }
        public void Goto()
        {
            Browser.Goto(Url);
        }

        public void LoginWith(string un = "Username", string pwd = "abc123")
        {
            var username = Browser.Driver.FindElement(By.Id("username"));
            username.SendKeys(un);
            var password = Browser.Driver.FindElement(By.Id("password"));
            password.SendKeys(pwd);
            var loginButton = Browser.Driver.FindElement(By.Id("login"));
            loginButton.Click();
        }

        public bool DisplaysInvalidUnPwMessage()
        {
            return message.Text == InvalidLoginMessage;
        }
    }
}

