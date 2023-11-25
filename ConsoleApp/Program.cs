using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        WebDriver driver = new FirefoxDriver();
        driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/SimpleCalculator/");
        CalcPage page = new CalcPage(driver);
        driver.Close();
    }
}

public class CalcPage
{
    private WebDriver driver;
    public CalcPage(WebDriver driver)
    {
        this.driver = driver;

        IWebElement aElm = driver.FindElement(aField);
        IWebElement bElm = driver.FindElement(aField);

        Console.WriteLine(aElm.GetAttribute("value"));
        Console.WriteLine(bElm.GetAttribute("value"));
    }

    public By aField = By.CssSelector("[ng-model='a']");
    public By bField = By.CssSelector("[ng-model='b']");
}