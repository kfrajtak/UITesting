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
    public class Class2
    {
        protected const string AppDriverUrl = "http://127.0.0.1:4723";
        protected const string WpfNotepadAppId = @"C:\Users\Karel\Downloads\wpfnotepad\Demo - WPF Notepad\Demo - WPF Notepad\bin\Debug\Demo - WPF Notepad.exe"; //copy and build binary from source https://codeoverload.wordpress.com/2010/05/01/wpf-notepad/   
        protected const string ExplorerAppId = @"wpfnotepad.exe";
        protected const string TargetSaveLocation = @"%TEMP%\";

        [Fact]
        public void BasicScenario()
        {
            // Launch Word Classic Windows Application
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", WpfNotepadAppId);
            var WpfnotepadSession = new IOSDriver<IOSElement>(new Uri(AppDriverUrl), appCapabilities);
            Assert.NotNull(WpfnotepadSession);

            var TextValue = "Hello WPF Notepad Application";
            WpfnotepadSession.FindElementByName("File").Click();
            WpfnotepadSession.FindElementByName("New").Click();
            var editBox = WpfnotepadSession.FindElementByClassName("TextBox");
            editBox.SendKeys(TextValue);
            Assert.Equal(TextValue, editBox.Text);
            System.Threading.Thread.Sleep(4000);
            WpfnotepadSession.Quit();
        }

        [Fact]
        public void BasicScenario2()
        {
            // Launch Word Classic Windows Application
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", WpfNotepadAppId);
            var WpfnotepadSession = new RemoteWebDriver(new Uri(AppDriverUrl), appCapabilities);
            Assert.NotNull(WpfnotepadSession);

            var TextValue = "Hello WPF Notepad Application";
            WpfnotepadSession.FindElementByName("File").Click();
            WpfnotepadSession.FindElementByName("New").Click();
            var editBox = WpfnotepadSession.FindElementByClassName("TextBox");
            editBox.SendKeys(TextValue);
            Assert.Equal(TextValue, editBox.Text);
            System.Threading.Thread.Sleep(4000);
            WpfnotepadSession.Quit();
        }
    }
}
