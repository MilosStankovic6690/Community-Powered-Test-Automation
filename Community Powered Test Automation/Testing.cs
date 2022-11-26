using Community_Powered_Test_Automation.Driver;
using Community_Powered_Test_Automation.Pages;
using OpenQA.Selenium.Support.UI;

namespace Community_Powered_Test_Automation
{
    public class Tests
    {

        private LoginPage _loginPage;
        private TestProjectExamplePage _testProjectExamplePage;
        [SetUp]
        public void BeforeScenario()
        {
            WebDrivers.Initialize();
            _loginPage = new LoginPage();
            _testProjectExamplePage= new TestProjectExamplePage();
            
        }
        [TearDown]
        public void AfterScenario()
        {
            WebDrivers.CleanUp();
        }

        [Test]
        public void TC01_InputAllTheFieldsOnTheHomePage_SaveAndLogoutAndItShouldWork()
        {
            Login("Milos_Stankovic", "12345");
            _testProjectExamplePage.CountryList("Serbia");
            _testProjectExamplePage.Address.SendKeys("Beograd");
            _testProjectExamplePage.Email.SendKeys("mail@mail.com");
            _testProjectExamplePage.Phone.SendKeys("325852");
            _testProjectExamplePage.SaveButton.Click();
            _testProjectExamplePage.LogoutButton.Click();   

            
            
            
        }

        public void Login(string name, string password)
        {
            _loginPage.LoginOnPage(name, password);
        }
    }
}