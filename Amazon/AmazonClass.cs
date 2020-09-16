using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    class AmazonClass
    {
        IWebDriver driver;
        IWebElement SearchInput, LoginField, PassField, ClickerElement;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\discD\\SeleniumChrome");
            
        }

        [Test]
        public void test()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://edufpmi.bsu.by/login/index.php";
        }

        public void StartWork()
        {
            bool flag = true;
            while (flag)
            {
                if (System.DateTime.Now.Hour == 8 && System.DateTime.Now.Minute == 17)
                {
                    LoginField = driver.FindElement(By.Id("username"));
                    LoginField.Click();
                    System.Threading.Thread.Sleep(541);
                    LoginField.SendKeys("fpm.lihovec");
                    System.Threading.Thread.Sleep(432);
                    PassField = driver.FindElement(By.Id("password"));
                    PassField.Click();
                    PassField.SendKeys("1823402");
                    System.Threading.Thread.Sleep(734);
                    SearchInput = driver.FindElement(By.Id("loginbtn"));
                    SearchInput.Click();
                    System.Threading.Thread.Sleep(1231);
                    flag = false;
                }
            }
        }

        [TearDown]
        public void closeBrowser()
        {
            
            //driver.Close();
            driver.Quit();
        }

    }
}
