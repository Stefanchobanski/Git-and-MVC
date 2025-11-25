using Pipes;
namespace PipesTest
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
        public void Pipes_View_ThrowEx_FormatEx()
        {
            Assert.Throws<FormatException>(() => view.ThrowEx("da", "4", "4", "4"));
        }

        [Test]
        public void Pipes_View_ThrowEx_Negative()
        {
            Assert.Throws<Exception>(() => view.ThrowEx("-5", "4", "4", "4"));
        }

        [TestCase("2000", "150", "100", "5", "The pool is 62% full. Pipe 1: 60%. Pipe 2: 40%.")]
        [TestCase("2000", "150", "100", "5", "The pool is 62% full. Pipe 1: 60%. Pipe 2: 40%.")]
        public void Pipes_Service_NewInput(string v, string p1, string p2, string hour, string result)
        {
            Assert.That(view.Display(v, p1, p2, hour), Is.EqualTo(result));
        }
    }
}
