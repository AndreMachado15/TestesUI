using Mereo_Pedido_Web_Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Xml.Linq;


namespace Mereo_Pedido_Web_Tests
{
    public class Config
    {

        public IWebDriver driver;

        private void HeadlessMode()
        {
            var headless = new ChromeOptions();
            headless.AddArgument("start-maximized");
            headless.AddArgument("disk-cache-size=0");
            headless.AddArgument("headless");

            driver = new ChromeDriver(headless);
        }

        [SetUp]
        public void Setup()
        {
            HeadlessMode();

            //Caso queira abrir o navegador, como é um teste simples é executado bem rápido.
            //driver = new ChromeDriver();

            //Aqui não consegui achar uma forma simples de pegar o caminho PedidoWeb\pedido.html, somente o caminho completo do arquivo.
            driver.Navigate().GoToUrl(@"C:\Users\andre\Downloads\Mereo_Pedido_Web\Mereo_Pedido_Web\PedidoWebPage\pedido.html");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
