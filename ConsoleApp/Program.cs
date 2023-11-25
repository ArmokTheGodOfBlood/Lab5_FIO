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
        Console.WriteLine(page.aField.GetAttribute("value"));
        Console.WriteLine(page.bField.GetAttribute("value"));
        driver.Close();
    }
}

public class CalcPage
{
    private WebDriver driver;
    public CalcPage(WebDriver driver)
    {
        this.driver = driver;

        aField = driver.FindElement(By.CssSelector("[ng-model='a']"));
        bField = driver.FindElement(By.CssSelector("[ng-model='b']"));
    }

    public IWebElement aField;
    public IWebElement bField;
}