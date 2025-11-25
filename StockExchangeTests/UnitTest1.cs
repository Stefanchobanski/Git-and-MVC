using StockExchange;
using System.Globalization;
namespace StockExchangeTests
{
    
    public class Tests
    {
        Service service;
        Controller controller;
        View view;

        [SetUp]
        public void Setup()
        {
            service = new Service();
            controller = new Controller(service);
            view = new View(controller);
        }

        [Test]
        public void ExchangeStock_View_ThrowEx_FormatEx()
        {
            Assert.Throws<FormatException>(() => view.ThrowsEx("daa", "45", "4", "fs"));
        }

        [Test]
        public void ExchangeStock_View_ThrowEx_NegativNumber()
        {
            Assert.Throws<Exception>(() => view.ThrowsEx("-5", "45", "4", "7"));
        }

        [TestCase("2.00", "3.50", "25", "10", "Общата цена е: 43.81 евро.")]
        [TestCase("0.9", "1.2", "100", "50", "Общата цена е: 77.32 евро.")]
        public void ExchangeStock_Service_NewInputTest(string priceVegetable, string priceFruts, string kgVegetable, string kgFruts, string result)
        {
            Assert.That(view.Display(priceVegetable, priceFruts, kgVegetable, kgFruts), Is.EqualTo(result));
        }

    }
}
