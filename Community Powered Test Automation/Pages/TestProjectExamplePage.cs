using Community_Powered_Test_Automation.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community_Powered_Test_Automation.Pages
{
    public class TestProjectExamplePage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public void CountryList(string text)
        {
            SelectElement element = new SelectElement(driver.FindElement(By.Id("country")));
            element.SelectByText(text);
        }
        public IWebElement Address => driver.FindElement(By.Id("address"));
        public IWebElement Email => driver.FindElement(By.Id("email"));
        public IWebElement Phone => driver.FindElement(By.Id("phone"));
        public IWebElement SaveButton => driver.FindElement(By.Id("save"));
        public IWebElement LogoutButton => driver.FindElement(By.Id("logout"));
        public IWebElement SaveText => driver.FindElement(By.ClassName("tp-saved"));

    }
}
