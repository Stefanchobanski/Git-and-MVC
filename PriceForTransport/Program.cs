namespace PriceForTransport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Stop за спиране: ");
                string input = Console.ReadLine(); 

                if (input == "Stop")
                {
                    break;
                }

                ServiceCalculate service = new ServiceCalculate();
                Controller controller = new Controller(service);
                View view = new View(controller);

                view.InputConsole();
            }

        }
    }
}
