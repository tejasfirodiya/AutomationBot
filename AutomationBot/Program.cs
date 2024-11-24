using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationBot;

public static class Program
{
    private static void Main(string[] args)
    {
        using IWebDriver driver = new ChromeDriver(@"C:\Tools\chromedriver-win32\chromedriver-win32");
        driver.Navigate().GoToUrl("https://www.google.com");
        Console.WriteLine("Google opened successfully!");
        driver.Quit();
    }
}