using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mereo_Pedido_Web_Elements
{
    public class PedidoElements
    {
        private readonly IWebDriver driver;

        public PedidoElements(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement inputValorPedido => driver.FindElement(By.Id("valorPedido"));
        public IWebElement btnCriar => driver.FindElement(By.Id("btnCriar"));
        public IWebElement textStatusPedido => driver.FindElement(By.Id("statusPedido"));

        public void DigitarValorTotal(string valor)
        {
            inputValorPedido.Clear();
            inputValorPedido.SendKeys(valor);
        }

        public string StatusPedido()
        {
            return textStatusPedido.Text;
        }

    }
}
