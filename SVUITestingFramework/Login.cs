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

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement username;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "login")]
        private IWebElement loginButton;

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
            username.SendKeys(un);
            password.SendKeys(pwd);
            loginButton.Click();
        }

        public bool DisplaysInvalidUnPwMessage()
        {
            return message.Text == InvalidLoginMessage;
        }
    }
}

