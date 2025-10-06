using OpenQA.Selenium;
using Mereo_Pedido_Web_Elements;


namespace Mereo_Pedido_Web_Tests
{
    class PedidoTests : Config
    {
        private PedidoElements elements;

        [SetUp]
        public void SetupTest()
        {
            /* 
             * Aqui criei uma instância do PedidoElements no driver. Assim eu consigo definir os elementos da página
             * em um arquivo próprio pra reduzir a manutenção e deixar o código mais limpo. Lá também criei funções
             * para não repetir código.
            */

            base.Setup();
            elements = new PedidoElements(driver);
        }

        [Test]
        public void DeveCriarPedidoComSucesso()
        {
            elements.DigitarValorTotal("100");
            elements.btnCriar.Click();

            Assert.That(elements.StatusPedido(), Is.EqualTo("Pedido criado com sucesso."));
        }

        [Test]
        public void DeveRetornarErroAoInserirValorInvalido()
        {
            elements.DigitarValorTotal("0");
            elements.btnCriar.Click();

            Assert.That(elements.StatusPedido(), Is.EqualTo("O valor do pedido deve ser maior que 0."));
        }
    }
}
