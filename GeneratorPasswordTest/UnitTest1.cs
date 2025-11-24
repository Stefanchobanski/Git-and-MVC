using PasswordGenerator;
namespace GeneratorPasswordTest
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
        public void GeneratorPass_View_ExeptionTest_FormatEx()
        {
            Assert.Throws<FormatException> (()=> view.ThrowEx("ds", "ds"));
        }
        [Test]
        public void GeneratorPass_View_ExeptionTest_Negative()
        {
            Assert.Throws<Exception>(() => view.ThrowEx("-1", "8"));
        }
        [TestCase("2", "1", "11aa2\n")]
        [TestCase("3", "3", "11aa2\n11aa3\n11ab2\n11ab3\n11ac2\n11ac3\n11ba2\n11ba3\n11bb2\n11bb3\n11bc2\n11bc3\n11ca2\n11ca3\n11cb2\n11cb3\n11cc2\n11cc3\n12aa3\n12ab3\n12ac3\n12ba3\n12bb3\n12bc3\n12ca3\n12cb3\n12cc3\n21aa3\n21ab3\n21ac3\n21ba3\n21bb3\n21bc3\n21ca3\n21cb3\n21cc3\n22aa3\n22ab3\n22ac3\n22ba3\n22bb3\n22bc3\n22ca3\n22cb3\n22cc3\n")]

        public void GeneratePass_Service_TryNewInput(string n, string i, string result)
        {
            Assert.That(view.Display(n, i), Is.EqualTo(result));
        }
    }
}
