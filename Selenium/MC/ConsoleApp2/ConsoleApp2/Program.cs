using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Automate
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IWebDriver driver;
                WebDriverWait wait;
                using (driver = new ChromeDriver())
                {
                    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                    driver.Navigate().GoToUrl(@"http://mastercontrol.radiometer.com/MC/index.cfm");

                    wait.Until<bool>((d) => { return d.Title.Contains("MasterControl"); });
                    IWebElement login = driver.FindElement(By.Id("wiaButton"));
                    login.Click();

                    //Thread.Sleep(10000);
                    wait.Until<bool>((d) => { return d.FindElements(By.Id("MyTasks")).Count != 0; });
                    IWebElement myTasks = driver.FindElement(By.Id("MyTasks"));
                    myTasks.Click();
                    Thread.Sleep(30000);
                    //wait.Until<bool>((d) => { return d.FindElements(By.XPath("//*[contains(@id, 'training_QI-00010 Commercial release')]")).Count != 0; });
                    //IWebElement firestTask = driver.FindElement(By.XPath("//[starts-with(@id, ‘training_QI-00010 Commercial release’)]"));

                    for (int i = 0; i < 3; i++)
                    {
                        IWebElement iframe = driver.FindElement(By.Id("myframe"));
                        driver.SwitchTo().Frame(iframe);

                        var table = driver.FindElement(By.Id("listDataTable"));
                        var rows = table.FindElements(By.TagName("tr"));
                        int count = 0;
                        foreach (var row in rows)
                        {
                            if (count == 0)
                            {
                                count++;
                                continue;
                            }

                            var rowTds = row.FindElements(By.TagName("td"));
                            foreach (var td in rowTds)
                            {
                                if (count == 1)
                                {
                                    count++;
                                    continue;
                                }

                                td.Click();
                                break;
                            }

                            break;
                        }

                        //IWebElement firstTak = driver.FindElements(By.XPath("//*[contains(@id, 'training_QI-00030')]"))[1];
                        //firstTak.Click();

                        Thread.Sleep(5000);

                        var materials = driver.FindElements(By.Id("materials"))[0];
                        materials.Click();
                        Thread.Sleep(3000);

                        var pdf = driver.FindElements(By.Id("portal.right.pdf.name"))[0];
                        pdf.Click();
                        Thread.Sleep(3000);
                        var tabs = driver.WindowHandles;
                        if (tabs.Count > 1)
                        {
                            driver.SwitchTo().Window(tabs[1]);
                            driver.Close();
                            driver.SwitchTo().Window(tabs[0]);
                            Thread.Sleep(2000);
                            IWebElement backToFrame = driver.FindElement(By.Id("myframe"));
                            driver.SwitchTo().Frame(backToFrame);
                        }

                        Thread.Sleep(5000);
                        var exam = driver.FindElements(By.Id("exam"))[0];
                        exam.Click();

                        Thread.Sleep(3000);
                        var readExam = driver.FindElements(By.Id("view_RMED Read and Understand Q Exam"))[0];
                        readExam.Click();

                        driver.SwitchTo().Window(driver.WindowHandles.Last());
                        Thread.Sleep(2000);
                        driver.SwitchTo().Frame(driver.FindElement(By.Id("bigFrame")));
                        Thread.Sleep(3000);
                        driver.SwitchTo().Frame(driver.FindElement(By.Id("questionFrame")));
                        Thread.Sleep(5000);
                        var radio = driver.FindElements(By.Id("correct_Yes / Ja"))[0];
                        radio.Click();

                        var submit = driver.FindElements(By.Id("submit_answer"))[0];
                        submit.Click();
                        Thread.Sleep(5000);
                        var signoff = driver.FindElements(By.Id("signoff-button"))[0];
                        signoff.Click();

                        driver.SwitchTo().Window(driver.WindowHandles.Last());
                        Thread.Sleep(3000);
                        driver.SwitchTo().Frame(driver.FindElement(By.Id("bigFrame")));
                        Thread.Sleep(8000);

                        var userid = driver.FindElements(By.Id("userID"));
                        if (userid.Count > 0)
                            userid[0].SendKeys("manle");

                        Thread.Sleep(2000);
                        var password = driver.FindElements(By.Id("password"))[0];
                        password.SendKeys("password");

                        Thread.Sleep(3000);
                        var end = driver.FindElements(By.Id("sign-off"))[0];
                        end.Click();

                        Thread.Sleep(30000);

                        driver.SwitchTo().Window(tabs[0]);

                        Thread.Sleep(7000);
                    }
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                // Get stack trace for the exception with source file information
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
            }
        }
    }
}
