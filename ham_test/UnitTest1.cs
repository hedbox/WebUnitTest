using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestClass]
    public class Login
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        private static string baseURL;
        private bool acceptNextAlert = true;
        
        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
        }
        
        [ClassCleanup]
        public static void CleanupClass()
        {
            try
            {
                //driver.Quit();// quit does not close the window
                driver.Close();
                driver.Dispose();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
        
        [TestInitialize]
        public void InitializeTest()
        {
            verificationErrors = new StringBuilder();
        }
        
        [TestCleanup]
        public void CleanupTest()
        {
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [TestMethod]
        public void TheLoginTest()
        {
            driver.Navigate().GoToUrl("https://portail-eh.varjak.fr/#/");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Accédez à la gestion de vos fournisseurs'])[1]/preceding::button[1]")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_1 | ]]
            driver.Navigate().GoToUrl("https://login.microsoftonline.com/b908ac01-ad71-408f-8b9c-9a6e4a5c0a96/oauth2/v2.0/authorize?client_id=470deb6a-c95c-42a5-8448-477ff96dfb7f&scope=user.read%20openid%20profile%20email%20offline_access&redirect_uri=https%3A%2F%2Fportail-eh.varjak.fr&client-request-id=1c58bcad-b37e-433e-a686-cbcfd2675017&response_mode=fragment&response_type=code&x-client-SKU=msal.js.browser&x-client-VER=2.24.0&client_info=1&code_challenge=OQODpj-Ov96bpNVdcGYfTNs0Le7KC9P8RgJTR0Z0D70&code_challenge_method=S256&prompt=select_account&nonce=d2deae72-1f24-46de-ab40-29fc54f2ca5b&state=eyJpZCI6IjNjMTdlNWE2LTI1MzgtNGRhMy1iNGEwLWQ1MjI1MWExYWM2YiIsIm1ldGEiOnsiaW50ZXJhY3Rpb25UeXBlIjoicG9wdXAifX0%3D");
            driver.FindElement(By.XPath("//div[@id='tilesHolder']/div/div/div/div/div[2]/div[2]/small")).Click();
            driver.Navigate().GoToUrl("https://portail-eh.varjak.fr/#code=0.AQsAAawIuXGtj0CLnJpuSlwKlmrrDUdcyaVChEhHf_lt-38LANU.AgABAAIAAAD--DLA3VO7QrddgJg7WevrAgDs_wUA9P_d-Xi0vsRzvWQEiz-YKsWM_Hz2leWMKYFYMSsfD9Pf0hbrYs15FlOy4fyzzb-4IlcV7_7U6LKLTfSEuYc1GmghXgDqb6MEnJMWViH62Fzvm3O9nnapgaAcp7dPF7ywl1lEHOQNMhk-SHy1vclWwJI9_2RnCQf1SmpNHctvsisK9DwFGAWSv09vqDVKURoVHvI8RveOqFHcGtPhmRC3pirrb-y5FLcOoIHvpSTNTFky0PmieKp6DUQdupMjV3F81_eTwdPuTlm9kq0kmZus4_EJEoR259QE49D3BX5rAKSTGkMM7Q79LmAXzHM9YUs62iFPQpQq5Pfj-t52pVm2nmKqVO716WZZ2ECO6HJcgLw65zSbfTZNX-ysZJRKOP5npQPe0_vdieXFv6F69jPe7CF5BP56Z_5eckkBQM7ELVUDuDuUXfpYX7Uwd3cEHZZTwhb3Q6s87hNjTapTgq-AxS0GZDHMgMqE2rVV8beNGDXNkGo1YNwu8hZcH_MXT8H1HKYU7QCfqFIdKs9dtP8FDzUwQsBivS7aXuQbfZZTGFgGDBfoYKSmYJ8EGc8W7b02HEQFr6bPxhQXDg-xs8wAbYkezJ0Np7x6XPbHqYhueKJRmZM0-Mpvq7i3JnO2rGqAWBDKYbZ47tPPgXgCGAPiFZF1am6PNqLOm7swaWNxj2swuyerVTySKo_WCNwN4sqSayeMjnIasqg6FxIrtajLnGDQq3C6bDGGYCafw6yE54Z3Xwf0toTmra9rCL_HhGzIaRLSnh2Vpi7UZCC5srFfeCCOStNp1R2GSploON3vnGVWcTC09IHyQQUGVaHSaXmz7MJ-rTyT-C1FVhc&client_info=eyJ1aWQiOiI4ZDFmM2Y4Ni02NmVhLTQyODUtYThlZS03ODFhZjk5MzcxN2EiLCJ1dGlkIjoiYjkwOGFjMDEtYWQ3MS00MDhmLThiOWMtOWE2ZTRhNWMwYTk2In0&state=eyJpZCI6IjNjMTdlNWE2LTI1MzgtNGRhMy1iNGEwLWQ1MjI1MWExYWM2YiIsIm1ldGEiOnsiaW50ZXJhY3Rpb25UeXBlIjoicG9wdXAifX0%3d&session_state=8572d486-f2fb-4696-b78d-baf8ad37ecca");
            driver.Close();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            driver.Navigate().GoToUrl("https://portail-eh.varjak.fr/#/fournisseurs");
            driver.FindElement(By.LinkText("Contacts")).Click();
            driver.Navigate().GoToUrl("https://portail-eh.varjak.fr/#/contacts");
            driver.FindElement(By.LinkText("IBANs")).Click();
            driver.Navigate().GoToUrl("https://portail-eh.varjak.fr/#/ibans");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Se déconnecter'])[1]/following::p[5]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Se déconnecter'])[1]/following::p[1]")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
