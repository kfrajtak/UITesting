using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class Class1
    {
        protected const string AppDriverUrl = "http://127.0.0.1:4723";
        protected const string AppId = @"C:\Work\playground\dist\App\bin\Debug\App.exe";

        [Fact]
        public void Test1()
        {
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("appId", "App");
            appCapabilities.SetCapability("app", AppId);
            var session = new RemoteWebDriver(new Uri(AppDriverUrl), appCapabilities);
            session.FindElementById("textBox1").SendKeys("This is some text");
        }

        [Fact]
        public void Test2()
        {
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("appId", "App");
            appCapabilities.SetCapability("app", AppId);
            var session = new RemoteWebDriver(new Uri(AppDriverUrl), appCapabilities);
            session.FindElementByName("textBox1").SendKeys("This is some text");
        }

        [Fact]
        public void Test3()
        {
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("appId", "App");
            appCapabilities.SetCapability("app", AppId);
            var session = new IOSDriver<IOSElement>(new Uri(AppDriverUrl), appCapabilities);
            session.FindElementById("textBox1").SendKeys("This is some text");
        }

        [Fact]
        public void Test4()
        {
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("appId", "App");
            appCapabilities.SetCapability("app", AppId);
            var session = new IOSDriver<IOSElement>(new Uri(AppDriverUrl), appCapabilities);
            session.FindElementByName("textBox1").SendKeys("This is some text");
        }

        [Fact]
        public void Test5()
        {
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("appId", "App");
            appCapabilities.SetCapability("app", AppId);
            var session = new RemoteWebDriver(new Uri(AppDriverUrl), appCapabilities);
            session.FindElementByTagName("Edit").SendKeys("This is some text");
            session.Quit();
        }
    }
}
