using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Auth0Validation
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            // SigncorrectValid();
            //SignUpuncrorctemailandcorrectpassword();
            //SignUpcorrectEmailandUncorrectpassword();
            LoginWithCorrectValid();
            //LoginUncorrectEmailAndUncorrectPassword();
            //LoginCorrectEmailAndcorrectPassword();
            //LoginUnCorrectEmailAndcorrectPassword();

        }


        public static void SignUpcorrectEmailandUncorrectpassword()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ashy-grass-05ad28c10.3.azurestaticapps.net/");
            IWebElement button = driver.FindElement(By.CssSelector("button.btn.btn-primary.w-100"));
            button.Click();
            IWebElement signUpBtn = driver.FindElement(By.CssSelector("a[class='c8d123439 ce1bebd2d']"));
            signUpBtn.Click();
            IWebElement nameInput = driver.FindElement(By.CssSelector("input[name='email']"));
            try
            {
        
                nameInput.SendKeys("TestAuth0@gmail.com");
             
            }
            catch
            {
                Console.WriteLine("Username wasn't sent");
            }
            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
            try
            {
                passwordInput.SendKeys("Test");
            }
            catch (Exception)
            {

                Console.WriteLine("Password uncorrect");
            }
            IWebElement Clickbtn = driver.FindElement(By.CssSelector("button[type='submit']"));
            Clickbtn.Click();
        }

        public static void SignUpuncrorctemailandcorrectpassword()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ashy-grass-05ad28c10.3.azurestaticapps.net/");
            IWebElement button = driver.FindElement(By.CssSelector("button.btn.btn-primary.w-100"));
            button.Click();
            IWebElement signUpBtn = driver.FindElement(By.CssSelector("a[class='c8d123439 ce1bebd2d']"));
            signUpBtn.Click();
            IWebElement nameInput = driver.FindElement(By.CssSelector("input[name='email']"));
            try
            {
                string EmailCorect = "TestAuth0@gmail.com";
                string uncorrectEmail = EmailCorect.Replace("@", "");
                nameInput.SendKeys(uncorrectEmail);
                Console.WriteLine($"Username was sent: {uncorrectEmail}");
            }
            catch
            {
                Console.WriteLine("Username wasn't sent");
            }
            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
            try
            {
                passwordInput.SendKeys("Test!!!12345");
               
            }
            catch (Exception)
            {

                Console.WriteLine("Password uncorrect");
            }
            IWebElement Clickbtn = driver.FindElement(By.CssSelector("button[type='submit']"));
            Clickbtn.Click();
        }

        public static void SigncorrectValid()
        {

            // Initialize the ChromeDriver
            IWebDriver driver = new ChromeDriver();

            // Navigate to the sign-up page on your website
            driver.Navigate().GoToUrl("https://ashy-grass-05ad28c10.3.azurestaticapps.net/");
            IWebElement button = driver.FindElement(By.CssSelector("button.btn.btn-primary.w-100"));
            button.Click();
            IWebElement signUpBtn = driver.FindElement(By.CssSelector("a[class='c8d123439 ce1bebd2d']"));
            signUpBtn.Click();

            try
            {
                IWebElement EmailInput = driver.FindElement(By.CssSelector("input[name='email']"));
                EmailInput.SendKeys("TestAuth00@gmail.com");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Wrong email");
            }
            try
            {
                IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
                passwordInput.SendKeys("Test!!!12345");

            }
            catch (Exception)
            {

                Console.WriteLine("uncorrect Password");
            }
            IWebElement Clickbtn = driver.FindElement(By.CssSelector("button[type='submit']"));
            Clickbtn.Click();
            System.Threading.Thread.Sleep(3000);
            driver.Quit();


        }
        public static void LoginWithCorrectValid()
        {

            // Initialize the ChromeDriver
            IWebDriver driver = new ChromeDriver();

            // Navigate to the sign-up page on your website
            driver.Navigate().GoToUrl("https://ashy-grass-05ad28c10.3.azurestaticapps.net/");
            IWebElement button = driver.FindElement(By.CssSelector("button.btn.btn-primary.w-100"));
            button.Click();

            try
            {

                IWebElement EmailInput = driver.FindElement(By.CssSelector("input[name='username']"));
                EmailInput.SendKeys("TestAuth00@gmail.com");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Wrong email");
            }
            try
            {

                IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
                passwordInput.SendKeys("Test!!!12345");

            }
            catch (Exception)
            {

                Console.WriteLine("uncorrect Password");
            }
            IWebElement Clickbtn = driver.FindElement(By.CssSelector("button[type='submit']"));
            Clickbtn.Click();
            System.Threading.Thread.Sleep(3000);
            driver.Quit();


        }
        public static void LoginUncorrectEmailAndUncorrectPassword()
        {

            // Initialize the ChromeDriver
            IWebDriver driver = new ChromeDriver();

            // Navigate to the sign-up page on your website
            driver.Navigate().GoToUrl("https://ashy-grass-05ad28c10.3.azurestaticapps.net/");
            IWebElement button = driver.FindElement(By.CssSelector("button.btn.btn-primary.w-100"));
            button.Click();

            try
            {

                IWebElement EmailInput = driver.FindElement(By.CssSelector("input[name='username']"));
                string EmailCorect = "TestAuth0@gmail.com";
                string uncorrectEmail = EmailCorect.Replace("@", "");
                EmailInput.SendKeys(uncorrectEmail);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Wrong email");
            }
            try
            {

                IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
                passwordInput.SendKeys("Test");

            }
            catch (Exception)
            {

                Console.WriteLine("uncorrect Password");
            }
            IWebElement Clickbtn = driver.FindElement(By.CssSelector("button[type='submit']"));
            Clickbtn.Click();
            System.Threading.Thread.Sleep(3000);
            driver.Quit();
        }
        public static void LoginCorrectEmailAndcorrectPassword()
        {

            // Initialize the ChromeDriver
            IWebDriver driver = new ChromeDriver();

            // Navigate to the sign-up page on your website
            driver.Navigate().GoToUrl("https://ashy-grass-05ad28c10.3.azurestaticapps.net/");
            IWebElement button = driver.FindElement(By.CssSelector("button.btn.btn-primary.w-100"));
            button.Click();

            try
            {

                IWebElement EmailInput = driver.FindElement(By.CssSelector("input[name='username']"));
                EmailInput.SendKeys("TestAuth00@gmail.com");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Wrong email");
            }
            try
            {

                IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
                passwordInput.SendKeys("Test");

            }
            catch (Exception)
            {

                Console.WriteLine("uncorrect Password");
            }
            IWebElement Clickbtn = driver.FindElement(By.CssSelector("button[type='submit']"));
            Clickbtn.Click();
            System.Threading.Thread.Sleep(3000);
            driver.Quit();
        }
        public static void LoginUnCorrectEmailAndcorrectPassword()
        {
            IWebDriver driver = new ChromeDriver();

            // Navigate to the sign-up page on your website
            driver.Navigate().GoToUrl("https://ashy-grass-05ad28c10.3.azurestaticapps.net/");
            IWebElement button = driver.FindElement(By.CssSelector("button.btn.btn-primary.w-100"));
            button.Click();

            try
            {

                IWebElement EmailInput = driver.FindElement(By.CssSelector("input[name='username']"));
                EmailInput.SendKeys("TestAuth08880@gmail.com");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Wrong email");
            }
            try
            {

                IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
                passwordInput.SendKeys("Test!!!12345");

            }
            catch (Exception)
            {

                Console.WriteLine("uncorrect Password");
            }
            IWebElement Clickbtn = driver.FindElement(By.CssSelector("button[type='submit']"));
            Clickbtn.Click();
            System.Threading.Thread.Sleep(3000);
            driver.Quit();
        }
    }
}