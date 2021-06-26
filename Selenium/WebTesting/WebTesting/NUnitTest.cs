using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;

namespace WebTesting
{
    
    public class NUnitTest
    {
        IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }
        [Test]
        public void OpenAppTest()
        {
            //driver.Url = "http://www.google.com";
            //Console.WriteLine(driver.Title);
            //Console.WriteLine(driver.PageSource);
            //Console.ReadLine();
            driver.Url = "http://www.google.com";
            //driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div/div[3]/center/input[2]")).Click();
            //driver.Navigate().Back();
            //driver.Navigate().Forward();
            //driver.Navigate().Refresh();

            IWebElement element = driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div/div[1]/div/div[1]/input"));
            element.SendKeys("Abhiroop");

            Console.WriteLine(element.TagName);
            Console.WriteLine(element.Size.Height);
            Console.WriteLine(element.Text);

            driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div/div[3]/center/input[1]")).Click();

        }
        [Test]
        public void OpenAppTest1()
        {
            driver.Url = "http://toolsqa.com/automation-practice-form/";
            driver.FindElement(By.Name("firstname")).SendKeys("Abhiroop");
            driver.FindElement(By.Name("lastname")).SendKeys("Mukherjee");
            driver.FindElement(By.Id("submit")).Click();
        }

        [Test]
        public void OpenAppTest2()
        {
            driver.Url = "http://toolsqa.com/automation-practice-form/";
            driver.FindElement(By.PartialLinkText("Partial")).Click();
            String s1 = driver.FindElement(By.TagName("button")).ToString();
            Console.WriteLine(s1);
            driver.FindElement(By.LinkText("Partial Link Test")).Click();

        }

        [Test]
        public void OpenAppTest3()
        {
            //bool b1 = false;
            driver.Url = "http://toolsqa.com/automation-practice-form/";
            IList<IWebElement> RB1 = driver.FindElements(By.Name("sex"));
            if (RB1.ElementAt(0).Selected)
            {
                RB1.ElementAt(1).Click();
            }
            else
            {
                RB1.ElementAt(0).Click();
            }

            driver.FindElement(By.Id("exp-2")).Click();

            IList<IWebElement> RB2 = driver.FindElements(By.Name("profession"));
            int size = RB2.Count();

            for (int i = 0; i < size; i++)
            {
                if (RB2.ElementAt(i).GetAttribute("value").Equals("Automation Tester"))
                {
                    RB2.ElementAt(i).Click();
                }
            }

            driver.FindElement(By.CssSelector("input[value='Selenium IDE']")).Click();
        }

        [Test]
        public void OpenAppTest4()
        {
            driver.Url = "http://toolsqa.com/automation-practice-form/";
            IWebElement Ie = driver.FindElement(By.Id("continents"));

            SelectElement oSelection = new SelectElement(Ie);

            oSelection.SelectByText("Africa");

            int size = oSelection.Options.Count;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(oSelection.Options.ElementAt(i).Text);
            }
        }
        [Test]
        public void OpenAppTest5()
        {
            driver.Url = "https://en.wikipedia.org/wiki/Programming_languages_used_in_most_popular_websites";
            IWebElement elemTable = driver.FindElement(By.XPath("/html/body/div[3]/div[3]/div[4]/div/table[1]"));

            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            string strRowData = "";

            foreach (var elemTr in lstTrElem)
            {
                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    foreach (var elemTd in lstTdElem)
                    {
                        strRowData = strRowData + elemTd.Text + "\t\t";
                    }
                }
                Console.WriteLine(strRowData);
                strRowData = String.Empty;
            }
            Console.WriteLine("");
            driver.Quit();
        }

        [Test]
        public void OpenAppTest6()
        {
            driver.Url = "http://toolsqa.com/automation-practice-switch-windows/";
            System.Threading.Thread.Sleep(12000);
            IWebElement Ie = driver.FindElement(By.Id("target"));

        }
        [Test]
        public void OpenAppTest7()
        {
            driver.Url = "https://www.toolsqa.com/automation-practice-switch-windows/";
            var alertButton = driver.FindElement(By.Id("alert"));
            alertButton.Click();
            var alert = driver.SwitchTo().Alert();
            var expected = "Knowledge increases by sharing but not by saving. Please share this website with your friends and in your organization.";
            Assert.AreEqual(expected, alert.Text);
            alert.Accept();
        }
        
        [Test]
        public void OpenAppTest8()
        {
            driver.Url = "https://www.toolsqa.com/automation-practice-switch-windows/";
            var newBrowser = driver.FindElement(By.Id("button1"));
            Assert.AreEqual(1, driver.WindowHandles.Count);
            string originalWindowTitle = "Demo Practice page for Switch Windows for Selenium Automation";
            Assert.AreEqual(originalWindowTitle, driver.Title);

            newBrowser.Click();
            Assert.AreEqual(2, driver.WindowHandles.Count);

            string newWindowHandle = driver.WindowHandles.Last();
            Console.WriteLine(newWindowHandle);
            var newWindow = driver.SwitchTo().Window(newWindowHandle);

            string expected = "QA Automation Tools Tutorial";
            Console.WriteLine(newWindow.Title);
            //newWindow.FindElement(By.Id("main-slideshow"));
            //Assert.AreEqual(expected, newWindow.Title);

        }

        [Test]
        public void OpenAppTest9()
        {
            driver.Url = "https://www.toolsqa.com/automation-practice-switch-windows/";
            var newBrowser = driver.FindElement(By.Id("button1"));
            Assert.AreEqual(1, driver.WindowHandles.Count);
            string originalWindowTitle = "Demo Practice page for Switch Windows for Selenium Automation";
            Assert.AreEqual(originalWindowTitle, driver.Title);

            newBrowser.Click();
            Assert.AreEqual(2, driver.WindowHandles.Count);

            string newWindowHandle = driver.WindowHandles.Last();
            Console.WriteLine(newWindowHandle);
            var newWindow = driver.SwitchTo().Window(newWindowHandle);

            string expected = "QA Automation Tools Tutorial";
            Console.WriteLine(newWindow.Title);
            //newWindow.FindElement(By.Id("main-slideshow"));
            //Assert.AreEqual(expected, newWindow.Title);

        }

        [Test]
        public void OpenAppTest10()
        {
            driver.Url = "https://www.toolsqa.com/automation-practice-switch-windows/";
            var alertButton = driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div/div/div[1]/div[2]/div/div/div/div/p[5]/button"));
            //alertButton.Click();

            string originalTabTitle = "Demo Practice page for Switch Windows for Selenium Automation";
            Assert.AreEqual(originalTabTitle, driver.Title);

            //string newTabHandle = driver.WindowHandles.Last();
            //var newTab = driver.SwitchTo().Window(newTabHandle);
            //Console.WriteLine(newTab.Title);
            //var expectedNewTabTitle = "QA Automation Tools Tutorial";
            //Assert.AreEqual(expectedNewTabTitle, newTab.Title);
        }

        [Test]
        public void OpenAppTest11()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://toolsqa.com/handling-alerts-using-selenium-webdriver/";

            //This step produce an alert on screen
            driver.FindElement(By.XPath("//*[@id='content']/p[4]/button")).Click();

            //Once alert is present try to click on any button on the page
            driver.FindElement(By.XPath("//*[@id='content']/p[16]/button")).Click();
        }

        [Test]
        public void OpenAppTest12()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://toolsqa.com/automation-practice-switch-windows/";

            // Store the parent window of the driver
            String parentWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("Parent window's handle -> " + parentWindowHandle);

            IWebElement clickElement = driver.FindElement(By.Id("button1"));

            // Multiple click to open multiple window
            for (var i = 0; i < 3; i++)
            {
                clickElement.Click();
                Thread.Sleep(3000);
            }

            // Store all the opened window into the list 
            // Print each and every items of the list
            List<string> lstWindow = driver.WindowHandles.ToList();
            foreach (var handle in lstWindow)
            {
                Console.WriteLine("Switching to window - > " + handle);
                Console.WriteLine("Navigating to google.com");

                //Switch to the desired window first and then execute commands using driver
                driver.SwitchTo().Window(handle);
                driver.Navigate().GoToUrl("http://google.com");
            }
        }

        [Test]
        public void OpenAppTest13()
        {
            
            driver.Url = "http://mastercontrol.radiometer.com/MC/index.cfm";
            driver.FindElement(By.XPath("/ html / body / div[1] / form / div[1] / div[4] / button[2] / span")).Click();
            //driver.SwitchTo().Alert().SendKeys("abhmu");
            //driver.SwitchTo().Alert().Accept();

            Thread.Sleep(40000);
            
            //driver.FindElement(By.XPath("//*[@id=\"mymastercontrol_text\"]")).Click();
            //driver.FindElement(By.XPath("//*[@id=\"MyTasks\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"taskLink4\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"arrow1\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"portal.right.pdf.name\"]")).Click();

            driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");

            //*[@id="portal.right.pdf.name"]

        }



        [TearDown]
        public void EndTest()
        {
            //driver.Close();
        }
    }
}
