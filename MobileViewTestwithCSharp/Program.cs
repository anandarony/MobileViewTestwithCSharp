using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

class MobileViewTest
{
    static void Main()
    {
        // Set up Chrome options to emulate mobile device (iPhone X)
        ChromeOptions chromeOptions = new ChromeOptions();
        chromeOptions.EnableMobileEmulation("iPhone X");


        IWebDriver driver = new ChromeDriver(chromeOptions);


        try
        {
            // Navigate to Google
            driver.Navigate().GoToUrl("https://www.google.com");

            // Wait until the page title contains "Google"
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TitleContains("Google"));

            // Output the page title
            Console.WriteLine("Page Title: " + driver.Title);
        }
        catch (WebDriverTimeoutException e)
        {
            Console.WriteLine("Timeout: " + e.Message);
        }
        finally
        {
            // Close the browser
            driver.Quit();
        }
    }
}



