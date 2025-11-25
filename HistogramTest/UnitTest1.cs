using Histogram;
namespace HistogramTest
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
        public void Histogram_View_ExxeptionNegativNumber()
        {
            List<string> list = new List<string> { "-1", "2", "-43" };
            Assert.Throws<Exception>(() => view.ThrowsEx(list));
        }
        [Test]
        public void Histogram_View_ExxeptionInvalidFormat()
        {
            List<string> list = new List<string> { "ds", "7", "8" };
            var ex = Assert.Throws<FormatException>(() => view.ThrowsEx(list));
            Assert.That(ex.Message, Is.EqualTo("The input string 'ds' was not in a correct format."));
        }
        [Test]
        public void Histogram_Service_AddNewInput()
        {
            List<string> list = new List<string> { "100", "250", "450", "650", "900" };
            Assert.That(view.DisplayOutput(list), Is.EqualTo("20.00%\n20.00%\n20.00%\n20.00%\n20.00%\n"));
        }

    }
}
