using Adventure;
namespace AdventureTests
{
    public class Tests
    {
        View view;
        Controller controller;
        Service service;

        [SetUp]
        public void Setup()
        {
            service = new Service();
            controller = new Controller(service);
            view = new View(controller);
        }

        [Test]
        public void Adventure_View_Throw_FormatEx()
        {
            Assert.Throws<FormatException>(() => view.ThrowEx("ds", "winter"));
        }
        [Test]
        public void Adventure_View_ExeptionTest_Negative()
        {
            Assert.Throws<Exception>(() => view.ThrowEx("-1", "summer"));
        }
        [TestCase("1000", "winter", "Somewhere in Balkans\nHotel – 800.00")]
        [TestCase("1200", "summer", "Somewhere in Europe\nHotel – 1080.00")]

        public void Adventure_Service_TryNewInput(string n, string i, string result)
        {
            Assert.That(view.Display(n, i), Is.EqualTo(result));
        }
    }
}
