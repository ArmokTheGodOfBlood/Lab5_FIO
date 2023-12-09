using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ConsoleApp
{
    public static class Program
    {

        public static CalcPage page;
        public static void Main()
        {
            SetupPageModel();
        }
        public static void SetupPageModel()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/SimpleCalculator/");
            page = new CalcPage(driver);
            driver.Close();
        }
    }

    public class CalcPage
    {
        private IWebDriver driver;

        public By aField = By.CssSelector("[ng-model='a']");
        public By bField = By.CssSelector("[ng-model='b']");

        public By aPlus = By.CssSelector("[ng-click='inca()']");
        public By aMinus = By.CssSelector("[ng-click='deca()']");
        public By bPlus = By.CssSelector("[ng-click='incb()']");
        public By bMinus = By.CssSelector("[ng-click='decb()']");

        public By combobox = By.CssSelector("[ng-model='operation']");
        public By opPlus = By.CssSelector("[value='+']");
        public By opMinus = By.CssSelector("[value='-']");
        public By opMult = By.CssSelector("[value='*']");
        public By opDiv = By.CssSelector("[value='/']");

        public By res = By.CssSelector("[class='result ng-binding']");

        public CalcPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public CalcPage SetInputA(string s)
        {
            driver.FindElement(aField).SendKeys(s);
            return this;
        }
        public CalcPage SetInputB(string s)
        {
            driver.FindElement(aField).SendKeys(s);
            return this;
        }

        public string GetInputA()
        {
            return driver.FindElement(aField).GetAttribute("value");
        }
        public string GetInputB()
        {
            return driver.FindElement(bField).GetAttribute("value");
        }

        public void ClickIncA()
        {
            driver.FindElement(aPlus).Click();
        }
        public void ClickDecA()
        {
            driver.FindElement(aMinus).Click();
        }
        public void ClickIncB()
        {
            driver.FindElement(bPlus).Click();
        }
        public void ClickDecB()
        {
            driver.FindElement(bMinus).Click();
        }
    }
}