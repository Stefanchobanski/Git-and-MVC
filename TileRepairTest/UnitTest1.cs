using TileRepair;
namespace TileRepairTest
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
        public void TileRepair_View_ThrowEx_FormatEx()
        {
            Assert.Throws<FormatException>(() => view.TrowsEx("daa", "1", "4", "4", "4"));
        }

        [Test]
        public void TileRepair_View_ThrowEx_NegativNumber()
        {
            Assert.Throws<Exception>(() => view.TrowsEx("-5", "45", "4", "7", "7"));
        }

        [TestCase("10", "1", "1", "2", "2", "96\n19.200000000000003")]
        [TestCase("25", "2.5", "1.2", "0", "0", "208.33333333333334\n41.66666666666667")]
        public void TileRepair_Service_NewInputTest(string a, string b, string c, string d, string e,string result)
        {
            Assert.That(view.Display(a, b, c, d, e), Is.EqualTo(result));
        }
    }
}
