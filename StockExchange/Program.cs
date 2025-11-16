namespace StockExchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            Controller controller = new Controller(service);
            View view = new View(controller);
            view.Display();
        }
    }
}
