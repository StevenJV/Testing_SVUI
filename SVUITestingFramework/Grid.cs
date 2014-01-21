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

        [FindsBy(How = How.XPath, Using = "//div[@id='carGrid']/table/thead/tr/th[2]/a/span")]
        private IWebElement filterButton;

        [FindsBy(How = How.CssSelector, Using = "input.k-textbox")]
        private IWebElement modelFilterTextbox1;

        [FindsBy(How = How.CssSelector, Using = "button.k-button")]
        private IWebElement modelFilterButton;

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
            filterButton.Click();
            modelFilterTextbox1.Clear();
            modelFilterTextbox1.SendKeys("BMW");
            modelFilterButton.Click();
        }

        public int CountRows()
        {
            return Browser.Driver.FindElements(By.XPath("//div[@id='carGrid']/table/tbody/tr")).Count;
        }
    }
}
