using ConsoleApp;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using static ConsoleApp.Program;
namespace Lab5_FIO
{
    public class UnitTest1: IDisposable
    {
        IWebDriver driver;
        private CalcPage page;
        public UnitTest1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/SimpleCalculator/");
            page = new CalcPage(driver);
        }

        public void Dispose()
        {
            driver.Close();
            driver.Dispose();
        }


        [Fact]
        public void TestIncrementA()
        {
            page.ClickIncA();
            string val = page.GetInputA();
            Assert.Equal("1", val);
        }
        [Fact]
        public void TestIncrementB()
        {
            page.ClickIncB();
            string val = page.GetInputB();
            Assert.Equal("1", val);
        }
        [Fact]
        public void TestDecrementA()
        {
            page.ClickDecA();
            string val = page.GetInputA();
            Assert.Equal("-1", val);
        }
        [Fact]
        public void TestDecrementB()
        {
            page.ClickDecB();
            string val = page.GetInputB();
            Assert.Equal("-1", val);
        }
    }
}