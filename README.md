Mobile View Testing with Selenium C#

This project demonstrates how to use Selenium WebDriver with C# to emulate mobile devices during browser testing. The code in this repository shows how to simulate an iPhone X view and navigate to Google, ensuring the webpage loads correctly in a mobile environment.
Features

    Mobile device emulation using ChromeDriver (iPhone X example).
    Configurable for testing on different mobile devices.
    Simple timeout handling.
    Uses WebDriver's explicit wait for improved reliability.

Prerequisites

Ensure the following tools and dependencies are installed on your machine:

    Visual Studio (or any C# IDE)
    ChromeDriver (added to your system's PATH)
    Selenium WebDriver and Selenium.Support via NuGet

NuGet Package Installation

To install the required NuGet packages, run the following commands:

bash

Install-Package Selenium.WebDriver
Install-Package Selenium.WebDriver.ChromeDriver
Install-Package Selenium.Support
Install-Package SeleniumExtras.WaitHelpers

Getting Started
Clone the Repository

Clone this project from GitHub:

bash

git clone https://github.com/anandarony/MobileViewTestwithCSharp.git

Running the Project

    Open the project in Visual Studio.
    Build the solution to restore dependencies.
    Run the project (press F5) to execute the mobile view test.

The browser will launch, navigate to Google, and output the page title.
Code Example

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

You can emulate other mobile devices by changing the device name in the EnableMobileEmulation method. For example, to emulate a Pixel 2, update the code to:

csharp

chromeOptions.EnableMobileEmulation("Pixel 2");

Contributions

Contributions and feedback are welcome! Feel free to open an issue or submit a Pull Request.
