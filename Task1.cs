using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace YourNamespace // Replace with your actual namespace

[TestFixture] //class that contains test
public class WebApplicationTests
{
    IWebDriver driver; //Webdriver interface

    [SetUp]  //Method run before each test
    public void Initialize()
    {
        // Initialize WebDriver
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://example.com"); // Replace with your application URL
    }

    
[Test] //method is a test method
public void LoginTest()
{
    // Locate and interact with login elements
    IWebElement usernameField = driver.FindElement(By.Id("username"));
    IWebElement passwordField = driver.FindElement(By.Id("password"));
    IWebElement loginButton = driver.FindElement(By.Id("loginButton"));

    usernameField.SendKeys("valid_username"); // Replace with a valid username
    passwordField.SendKeys("valid_password"); // Replace with a valid password
    loginButton.Click();

    
     // Use WebDriverWait to wait for elements after login
     WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); // Wait for up to 10 seconds
     
    // Wait for the page to load (Replace "Page Title" with the actual title)
     wait.Until(ExpectedConditions.TitleIs("Page Title"));

    // Navigate to a specific web page
    driver.Navigate().GoToUrl("http://example.com/specific_page"); // Replace with the specific page URL

    // Verify presence of specific elements
    IWebElement buttonElement = driver.FindElement(By.Id("buttonId")); // Replace with the actual ID of the button
    IWebElement linkElement = driver.FindElement(By.LinkText("Link Text")); // Replace with the actual link text
    IWebElement textFieldElement = driver.FindElement(By.Name("fieldName")); // Replace with the actual name of the field

    Assert.IsTrue(buttonElement.Displayed);
    Assert.IsTrue(linkElement.Displayed);
    Assert.IsTrue(textFieldElement.Displayed);
}

    [TearDown] //Method run after each test
    public void CleanUp()
    {
        // Close the browser
        driver.Quit();
    }
}
