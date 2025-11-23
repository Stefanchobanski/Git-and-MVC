using NUnit.Framework;
using PriceForTransport;
using System.Globalization;
namespace PriceForTransportTest
{
    public class Tests
    {
        View view;
        Controller controller;
        ServiceCalculate service;

        [SetUp]
        public void Setup()
        {
            service = new ServiceCalculate();
            controller = new Controller(service);
            view = new View(controller);
        }

        [Test]
        public void PriceForTransport_Model_TypeNegativKm()
        {
            var ex = Assert.Throws<Exception>(() => view.ThrowsEx("-8", "day"));
            Assert.That(ex.Message, Is.EqualTo("Негативни КМ"));
        }
        [Test]
        public void PriceForTransport_Model_TypeInvalidTimeDay()
        {
            var ex = Assert.Throws<Exception>(() => view.ThrowsEx("8", "gdgd"));
            Assert.That(ex.Message, Is.EqualTo("Невалиден вход за част от деня"));
        }
        [Test]
        public void PriceForTransport_View_FormatEx_Km()
        {
            var ex = Assert.Throws<FormatException>(() => view.ThrowsEx("hfhf", "day"));
            Assert.That(ex.Message, Is.EqualTo("The input string 'hfhf' was not in a correct format."));
        }
    }
}
