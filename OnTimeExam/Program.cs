namespace OnTimeExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service sevrvice = new Service();
            Controller controller = new Controller(sevrvice);
            View view = new View(controller);

            while (true)
            {
                Console.Write("Въдеди Stop за да спе: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "stop")
                {
                    break;
                }
                view.Display();
            }
        }
    }
}
