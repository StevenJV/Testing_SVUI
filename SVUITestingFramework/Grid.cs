using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;

namespace SVUITestingFramework
{
    public class Grid
    {
        private static string PageTitle = "Grid";
        private static string Url = "http://sv-ui.herokuapp.com/grid.html";

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }
        public void Goto()
        {
            Browser.Goto(Url);
        }

        public void FilterByBMW()
        {
            Browser.Driver.FindElement(By.XPath("//div[@id='carGrid']/table/thead/tr/th[2]/a/span")).Click();
            Browser.Driver.FindElement(By.CssSelector("input.k-textbox")).Clear();
            Browser.Driver.FindElement(By.CssSelector("input.k-textbox")).SendKeys("BMW");
            Browser.Driver.FindElement(By.CssSelector("button.k-button")).Click();
        }

        public int CountRows()
        {
            return Browser.Driver.FindElements(By.XPath("//div[@id='carGrid']/table/tbody/tr")).Count;
        }
    }
}
