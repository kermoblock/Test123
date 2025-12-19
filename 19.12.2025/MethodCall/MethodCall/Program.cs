namespace MethodCall
{
    internal class Program
    {
        //Kutsuda meetod välja
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string input = Console.ReadLine();

            switch (input)
            {
            case "Sayhello":
                SayHello();
                break;

            case "SayGoodbye":
                SayGoodbye();
                break;
            }

        static void SayHello()
            {
                Console.WriteLine("Hello");
            }

        static void SayGoodbye()
        {
            Console.WriteLine("Goodbye");
        }
    }
}
}
