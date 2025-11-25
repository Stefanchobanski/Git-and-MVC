using MagicNumber;
namespace MagicNumberTest
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
        public void MagicNumber_View_ThrowEx_FormatEx()
        {
            Assert.Throws<FormatException>(() => view.ThrowEx("da"));
        }
        [TestCase("1", "111111\n")]
        [TestCase("3", "111113\n111131\n111311\n113111\n131111\n311111\n")]
        public void Pipes_Service_NewInput(string n, string result)
        {
            Assert.That(view.Display(n), Is.EqualTo(result));
        }
    }
}
