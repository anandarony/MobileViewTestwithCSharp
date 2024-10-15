Mobile View Testing with Selenium C# – README

This repository demonstrates how to emulate mobile device views using Selenium WebDriver with C#. The example code emulates an iPhone X and navigates to Google's homepage, ensuring the page is loaded successfully. This project is ideal for those looking to automate mobile view testing without the need for physical devices.
Features

    Emulates mobile devices using ChromeDriver.
    Supports navigation to any URL and waits for page load.
    Includes basic error handling for timeouts.
    Easily configurable to test on other mobile devices (e.g., Pixel 2, iPad).

Prerequisites

Ensure you have the following installed on your machine:

    Visual Studio (or any C# IDE)
    ChromeDriver installed and added to your system's PATH.
    Selenium WebDriver and Selenium.Support packages installed via NuGet.

Installing NuGet Packages

Run the following commands in your NuGet Package Manager Console:

bash

Install-Package Selenium.WebDriver
Install-Package Selenium.WebDriver.ChromeDriver
Install-Package Selenium.Support
Install-Package SeleniumExtras.WaitHelpers

Getting Started
Cloning the Repository

Clone this repository using:

bash

git clone https://github.com/yourusername/mobile-view-testing-selenium-csharp.git

Running the Project

    Open the project in Visual Studio or your preferred C# IDE.
    Build the solution to restore NuGet dependencies.
    Press F5 to run the program.

The test will open Google in an iPhone X emulated view, wait until the page is loaded, and then output the page title.
Sample Code

csharp

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

        // Initialize WebDriver with ChromeOptions
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

Customization

To test on different devices, you can change the device name in the EnableMobileEmulation method. For example, to emulate a Pixel 2, modify the line:

csharp

chromeOptions.EnableMobileEmulation("Pixel 2");

You can find a list of supported device names in Chrome DevTools.
Issues and Contributions

Feel free to report issues or contribute to the project by opening a Pull Request. Contributions are always welcome!
