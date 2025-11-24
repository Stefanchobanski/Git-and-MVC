using OnTimeExam;
namespace OnTimeExamTest
{
    public class Tests
    {
        Service _service;
        Controller _controller;
        View _view;

        [SetUp]
        public void Setup()
        {
            _service = new Service();
            _controller = new Controller(_service);
            _view = new View(_controller);
        }

        [Test]
        public void OnTimeExam_View_NegativTime()
        {
           var ex = Assert.Throws<Exception>(() => _view.ThrowsEx("-8", "54", "41", "4"));
            Assert.Throws<Exception>(() => _view.ThrowsEx("4", "-54", "41", "4"));
            Assert.Throws<Exception>(() => _view.ThrowsEx("4", "54", "-41", "4"));
            Assert.Throws<Exception>(() => _view.ThrowsEx("4", "54", "41", "-4"));
            Assert.That(ex.Message, Is.EqualTo("Негативни данни"));
        }

        [Test]
        public void OnTimeExam_View_TimeMinUp60()
        {
           var ex = Assert.Throws<Exception>(() => _view.ThrowsEx("5", "60", "8", "80"));
            Assert.That(ex.Message, Is.EqualTo("Въведени минути повече от 60"));
        }

        [Test]
        public void OnTimeExam_View_TimeHoursUp24()
        {
            var ex = Assert.Throws<Exception>(() => _view.ThrowsEx("25", "0", "26", "8"));
            Assert.That(ex.Message, Is.EqualTo("Въведен час повече от 24"));
        }

        [TestCase ("10", "00", "9", "10", "Early\n50 minutes before the start")]
        [TestCase ("8", "30", "8", "55", "Late\n25 minutes after the start")]
        public void OnTimeExam_Service_AddNewInput(string hourExam, string minExam, string hourArrive, string minArrive, string result)
        {
            Assert.That(_view.Display(hourExam, minExam, hourArrive, minArrive), Is.EqualTo(result));
        }
    }
}
